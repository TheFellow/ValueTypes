using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ValueTypesTests.Names;

namespace ValueTypesTests
{
    [TestClass]
    public class NamesTests
    {
        private Seat Alice => new(new PersonalName("Alice", "Wonderland"), 4);
        private Seat Bob => new(new PersonalName("Bob", "Wonderland"), 5);
        private Seat Charles => new(new PersonalName("Charles", "Leclerc"), 6);

        EqualityComparer<Classroom> _classroomComparer = EqualityComparer<Classroom>.Default;
        EqualityComparer<Rollcall> _rollcallComparer = EqualityComparer<Rollcall>.Default;

        [TestMethod]
        public void Classroom_OfSameSize_IgnoresOrder()
        {
            var classroom1 = new Classroom(new[] { Alice, Bob, Charles });
            var classroom2 = new Classroom(new[] { Bob, Charles, Alice });

            Assert.AreEqual(classroom1, classroom2);
            Assert.IsTrue(_classroomComparer.Equals(classroom1, classroom2));
            Assert.IsTrue(classroom1.Equals(classroom2));
            Assert.IsTrue(classroom1 == classroom2);
            Assert.IsTrue(classroom2 == classroom1);
            Assert.IsFalse(classroom1 != classroom2);
            Assert.IsFalse(classroom2 != classroom1);
        }

        [TestMethod]
        public void Classroom_OfDifferenceSize_IsDifferent()
        {
            var classroom1 = new Classroom(new[] { Alice, Bob, Charles });
            var classroom2 = new Classroom(new[] { Bob, Charles });

            Assert.AreNotEqual(classroom1, classroom2);
            Assert.IsFalse(_classroomComparer.Equals(classroom1, classroom2));
            Assert.IsFalse(classroom1.Equals(classroom2));
            Assert.IsFalse(classroom1 == classroom2);
            Assert.IsFalse(classroom2 == classroom1);
            Assert.IsTrue(classroom1 != classroom2);
            Assert.IsTrue(classroom2 != classroom1);
        }

        [TestMethod]
        public void Rollcalls_OfSameClassInSameOrder_IsEquals()
        {
            var rollcall1 = new Rollcall(new[] { Alice, Bob, Charles });
            var rollcall2 = new Rollcall(new[] { Alice, Bob, Charles });

            Assert.AreEqual(rollcall1, rollcall2);
            Assert.IsTrue(_rollcallComparer.Equals(rollcall1, rollcall2));
            Assert.IsTrue(rollcall1.Equals(rollcall2));
            Assert.IsTrue(rollcall1 == rollcall2);
            Assert.IsTrue(rollcall2 == rollcall1);
            Assert.IsFalse(rollcall1 != rollcall2);
            Assert.IsFalse(rollcall2 != rollcall1);
        }

        [TestMethod]
        public void Rollcalls_OfSameClassInDifferentOrder_AreDifferent()
        {
            var rollcall1 = new Rollcall(new[] { Alice, Bob, Charles });
            var rollcall2 = new Rollcall(new[] { Bob, Alice, Charles });

            Assert.AreNotEqual(rollcall1, rollcall2);
            Assert.IsFalse(_rollcallComparer.Equals(rollcall1, rollcall2));
            Assert.IsFalse(rollcall1.Equals(rollcall2));
            Assert.IsFalse(rollcall1 == rollcall2);
            Assert.IsFalse(rollcall2 == rollcall1);
            Assert.IsTrue(rollcall1 != rollcall2);
            Assert.IsTrue(rollcall2 != rollcall1);
        }

        [TestMethod]
        public void Rollcalls_OfDifferentClassInSimilarOrder_AreDifferent()
        {
            var rollcall1 = new Rollcall(new[] { Alice, Bob, Charles });
            var rollcall2 = new Rollcall(new[] { Alice, Bob });

            Assert.AreNotEqual(rollcall1, rollcall2);
            Assert.IsFalse(_rollcallComparer.Equals(rollcall1, rollcall2));
            Assert.IsFalse(rollcall1.Equals(rollcall2));
            Assert.IsFalse(rollcall1 == rollcall2);
            Assert.IsFalse(rollcall2 == rollcall1);
            Assert.IsTrue(rollcall1 != rollcall2);
            Assert.IsTrue(rollcall2 != rollcall1);
        }
    }
}
