# ValueTypes
An easy-to-use implementation of ValueObjects from DDD. 
![ValueTypes](./ValueTypes-Small.png)

Icon made by [Freepik]("https://www.flaticon.com/authors/freepik") from [Flaticon]("https://www.flaticon.com/")

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

### Sequences (Nested Yield)
These case represent almost the opposite of a Group. This is for use in a case where you have a sequence of `Values` that
are just one part of your `Value`. These are cases where you want to `Yield` a whole sequence of `Value` types in a single unit.

Order within the unit does matter, otherwise you'd just use a `Group`. An example would help here.

Suppose you are modelling two aspects of a classroom. The room itself, and the process of taking attendance.
If there are the same people in the classroom in the same seats then we want to say the classroom is the same.
On the other hand, when taking attendance the people in the classroom may enter in different orders;
In this case rollcall goes differently because it's in a different order. Same people, same seats, different order means different rollcall.

(I know this is a bit of a stretched example, I wish I would have done the difference between the bill at
a restaurant and the receipt printing order but I'm committed to the tests I wrote now...)

The way to pull this off is by using an extension method on `IEnumerable<T>` called `AsValues()` where
`T` either is a `Value` or can be cast to one. All of the same primitive types plus `string` and `Guid` are supported.

From the tests; Classroom is order independent, so `Group` is used:
``` csharp
public class Classroom : Value
{
    private readonly Seat[] _seats;

    public Classroom(IEnumerable<Seat> seats) => _seats = seats.ToArray();

    protected override IEnumerable<ValueBase> GetValues() => Group(_seats);
}
```

Rollcall, however, is order dependent, so we `Yield` using `AsValues`.
``` csharp
public class Rollcall : Value
{
    public IEnumerable<Seat> Seats { get; }
    public Rollcall(IEnumerable<Seat> seats) => Seats = seats;

    protected override IEnumerable<ValueBase> GetValues() => Yield(Seats.AsValues());
}
```

The `AsValues` extension method essentially let's you `Yield` a standalone sequence of values
in lieu of having to write `Yield(Field1, Field2, ...)`

Note that you can certainly mix and match these things together as needed:

``` csharp
public class ChemicalCompound : Value
{
    public string Name { get; }
    public Symbol ChemicalSymbol { get; }
    public IEnumerable<Elements> Elements { get; }

    public ChemicalCompound(string name, Symbol chemicalSymbol, IEnumerable<Elements> elements) =>
        (Name, ChemicalSymbol, Elements) = (name, chemicalSymbol, elements.ToList());

    protected override IEnumerable<ValueBase> GetValues() => Yield(Name, ChemicalSymbol, Elements.AsValues());
}
```

### Groups

"But I want to do that same thing with nested groups!" you say.
Not a problem, we've got you covered. Just use `AsGroup`!

This has the same effect as using the `Group` method to return an unordered collection of properties with Value-type semantics.

Here's an example from the Finance tests which shows that what makes wallets equal is their contents, ignoring order.
A `Wallet` contains `Money` and `CreditCards`. Here'e is its complete definition:

```csharp
public class Wallet : Value
{
    private IEnumerable<Money> Cash { get; }
    private IEnumerable<CreditCard> CreditCards { get; }

    public Wallet(IEnumerable<Money> cash, IEnumerable<CreditCard> creditCards) =>
        (Cash, CreditCards) = (cash, creditCards);

    protected override IEnumerable<ValueBase> GetValues() => Yield(Cash.AsGroup(), CreditCards.AsGroup());
}
```

The following `Wallet` instances are equal.
(I have some extension methods helping make this all more compact.)
Note that order does not matter in either case:
``` csharp
var wallet1 = new Wallet(
    new[] { 20m.Dollars(), 10m.Euros(), 5m.Euros() },
    new[] { CreditCompany.Visa.For(1000m.ToAmount()), CreditCompany.MasterCard.For(5000m.ToAmount())
    });

var wallet2 = new Wallet(
    new[] { 10m.Euros(), 20m.Dollars(), 5m.Euros() },
    new[] { CreditCompany.MasterCard.For(5000m.ToAmount()), CreditCompany.Visa.For(1000m.ToAmount())
    });
```

### Comments

If you have a combination of unordered collections, and single members, you can just
`Concat` the two lists together (from Yield() and Group()).

Or, as of 1.1.0 you can simply `Yield(Items.AsValues(), GroupOfThings.AsGroup(), ...)`

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

----

**Tuples** of values work as expected.

For example, a tuple of values behaves correctly:
``` csharp
var t1 = (new Point2d(4, 8), new Point2d(15, 16));
var t2 = (new Point2d(4, 8), new Point2d(15, 16));

Assert.AreEqual(t1, t2); // Works
```

There is no handling for classes which have tuple members.
This, though, seems *super* unlikely, so I'm not worried about it.