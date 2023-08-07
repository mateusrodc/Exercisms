using Exercisms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsFilterTest
    {
        [TestMethod]
        public void Filter_ShouldReturnEmptyList_WhenNoMatchFound()
        {
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 };

            List<int> result = ListOps.Filter(inputList, x => x > 10);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Filter_ShouldReturnFilteredList_WhenMatchFound()
        {
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 };

            List<int> result = ListOps.Filter(inputList, x => x % 2 == 0);

            CollectionAssert.AreEqual(new List<int> { 2, 4 }, result);
        }

        [TestMethod]
        public void Filter_ShouldReturnAllElements_WhenPredicateAlwaysTrue()
        {
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 };

            List<int> result = ListOps.Filter(inputList, x => true);

            CollectionAssert.AreEqual(inputList, result);
        }

        [TestMethod]
        public void Filter_ShouldReturnEmptyList_WhenPredicateAlwaysFalse()
        {
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 };

            List<int> result = ListOps.Filter(inputList, x => false);

            Assert.AreEqual(0, result.Count);
        }
    }
}