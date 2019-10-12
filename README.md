# ValueTypes
An easy-to-use implementation of ValueObjects from DDD.

## Summary

There is no out-of-the box solution in C# for structural equality.
The goal of this little library is to make it as easy as possible to use
ValueTypes.

The focus of this library is on the developer.
It should **as painless as possible** to implement Value Types!

## Usage

Make all of your value types inherit from the abstract `Value` class.
You'll be required to implement the `GetValues` method, which returns `IEnumerable<ValueBase>`.

`ValueBase` is the base type of `Value`, and contains an implicit cast from **every base type**
besides object.
Thus implementing `GetValues()` is as simple as yielding your primitives;
the cast handles the rest for you!

``` csharp
public override IEnumerable<ValueBase> GetValues()
{
    yield return _count;     // int
    yield return _factor;    // double
    yield return _type;      // string
    // More as needed...
}
```

This form is useful when your Value contains simple types and a list of other simple types.
But we want this to be easy, and plenty of ValueTypes *do not* have this,
so how do we make our lives easier?

### Value.Yield()

If all you need to do is list the components to be included then `Value.Yield();` is the answer.
Here's a complete example from the unit tests, for a 2d point:

``` csharp
public sealed class Point2d : Value
{
    public int X { get; }
    public int Y { get; }

    public Point2d(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    protected override IEnumerable<ValueBase> GetValues() => Yield(X, Y);
}
```

The signature is `Yield(params ValueBase[] values)` so you're free to pass as many
arguments as needed. The implict cast takes care of everything else for you.
It doesn't get much simpler than that!

### Value.Group()

There are occassions where this will not be sufficient, however.
For example, sometimes a collection of values should be Equal regardless of their order.

As an example, let's say that we have a `Wallet` type which contains a collection of dollar bills.
Suppose in the implementation we have a simple `List<DollarBill>`,
where `DollarBill` is abstract, and has subtypes for each dollar bill;
`Twenty : DollarBill` for example.

What we want is for a wallet containing these five bills `$1, $1, $5, $20, $20`
to match another wallet containing `$20, $20, $1, $5, $1`.
The order in which these values get `yield`ed causes these not to be considered equal.

Value.Group() to the rescue!
In lieu of using `Yield()` you just use the helper method `Group()`.

Another example, from the unit tests, is shown below.
Here we're modelling a line segment.
Crucially, a line segment is *undirected*.
That is, it doesn't have a begin and end, it's simply the line joining two points.
Thus, the order of the two `Point2d`s that indicate the two ends is not important to equality.

``` csharp
public class LineSegment : Value
{
    public Point2d A { get; }
    public Point2d B { get; }

    public LineSegment(Point2d a, Point2d b)
    {
        A = a;
        B = b;
    }

    protected override IEnumerable<ValueBase> GetValues() => Group(A, B);
}
```

In this way, the line from (2,3) to (4,5) is the same as
the segment from (4,5) to (2,3).

If we were to use `Yield()` we would be implementing a `Vector`, which is directed.

### Comments

If you have a combination of unordered collections, and single members, you can just
`Concat` the two lists together (from Yield() and Group()).

----

**Dates** deserve special care, which is why there's no cast from a DateTime.
The problem with dates is that their equality depends on the resolution you need.

Suppose you have a `TransactionDate` which is only supposed to indicate a date.
That is, {07/04/2019 01:23:45} should be the same as {07/04/2019 08:06:13}.
(Because the year, month, and day match and we don't care about time components.)

This is likely already handled by your business logic, but I don't make that assumption.

So what do I do?

The recommended solution for this example would be to Yield
`date.ToString("yyyyMMdd")`.
This converts the DateTime into a string with precision appropriate for the desired Equality.
