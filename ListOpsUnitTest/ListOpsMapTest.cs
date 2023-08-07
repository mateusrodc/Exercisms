using Exercisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsMapTest
    {
        [TestMethod]
        public void Map_ShouldReturnEmptyList_WhenInputListIsEmpty()
        {
            var emptyList = new List<int>();
            Func<int, string> function = x => (x * x).ToString();

            var result = ListOps.Map(emptyList, function);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void Map_ShouldReturnMappedList_WhenInputListIsNotEmpty()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            Func<int, string> function = x => (x * x).ToString();

            var result = ListOps.Map(list, function);

            Assert.AreEqual(list.Count, result.Count);
            CollectionAssert.AreEqual(new List<string> { "1", "4", "9", "16", "25" }, result);
        }
    }
}
