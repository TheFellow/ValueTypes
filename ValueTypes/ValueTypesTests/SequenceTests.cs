using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ValueTypes;

namespace ValueTypesTests
{
    class Word : Value
    {
        private readonly string _word;
        public Word(string word) => _word = word;
        protected override IEnumerable<ValueBase> GetValues() => Yield(_word);
    }

    class Statement : Value
    {
        private readonly Word[] _first;
        private readonly Word[] _second;

        public Statement(Word[] first, Word[] second) => (_first, _second) = (first, second);

        protected override IEnumerable<ValueBase> GetValues() => Yield(_first.AsValues(), _second.AsValues());
    }

    [TestClass]
    public class SequenceTests
    {
        Word Hello => new Word("Hello");
        Word There => new Word("there");
        Word Friend => new Word("friend.");

        EqualityComparer<Statement> _comparer = EqualityComparer<Statement>.Default;

        [TestMethod]
        public void SameStatements_WithEmptyWordGroups_AreEqual()
        {
            var statement1 = new Statement(new[] { Hello, There }, new Word[] { });
            var statement2 = new Statement(new[] { Hello, There }, new Word[] { });

            Assert.AreEqual(statement1, statement2);
            Assert.IsTrue(_comparer.Equals(statement1, statement2));
            Assert.IsTrue(statement1.Equals(statement2));
            Assert.IsTrue(statement2.Equals(statement1));
            Assert.IsTrue(statement1 == statement2);
            Assert.IsTrue(statement2 == statement1);
            Assert.IsFalse(statement1 != statement2);
            Assert.IsFalse(statement2 != statement1);
        }

        [TestMethod]
        public void SameStatements_InSameOrder_AreEqual()
        {
            var statement1 = new Statement(new[] { Hello, There }, new[] { Friend });
            var statement2 = new Statement(new[] { Hello, There }, new[] { Friend });

            Assert.AreEqual(statement1, statement2);
            Assert.IsTrue(_comparer.Equals(statement1, statement2));
            Assert.IsTrue(statement1.Equals(statement2));
            Assert.IsTrue(statement2.Equals(statement1));
            Assert.IsTrue(statement1 == statement2);
            Assert.IsTrue(statement2 == statement1);
            Assert.IsFalse(statement1 != statement2);
            Assert.IsFalse(statement2 != statement1);
        }

        [TestMethod]
        public void MultipleStatements_WithSameOrdering_AreDifferent()
        {
            var statement1 = new Statement(new[] { Hello, There }, new[] { Friend });
            var statement2 = new Statement(new[] { Hello }, new[] { There, Friend });

            Assert.AreNotEqual(statement1, statement2);
            Assert.IsFalse(_comparer.Equals(statement1, statement2));
            Assert.IsFalse(statement1.Equals(statement2));
            Assert.IsFalse(statement2.Equals(statement1));
            Assert.IsFalse(statement1 == statement2);
            Assert.IsFalse(statement2 == statement1);
            Assert.IsTrue(statement1 != statement2);
            Assert.IsTrue(statement2 != statement1);
        }

        [TestMethod]
        public void DifferentStatements_AreDifferent()
        {
            var statement1 = new Statement(new[] { Hello, There }, new Word[] { });
            var statement2 = new Statement(new[] { Hello, Friend }, new Word[] { });

            Assert.AreNotEqual(statement1, statement2);
            Assert.IsFalse(_comparer.Equals(statement1, statement2));
            Assert.IsFalse(statement1.Equals(statement2));
            Assert.IsFalse(statement2.Equals(statement1));
            Assert.IsFalse(statement1 == statement2);
            Assert.IsFalse(statement2 == statement1);
            Assert.IsTrue(statement1 != statement2);
            Assert.IsTrue(statement2 != statement1);
        }
    }
}
