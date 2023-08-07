using Exercisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsConcatenateTest
    {
        [TestMethod]
        public void Concatenate_ShouldReturnSingleList_WhenSingleListIsPassed()
        {
            var list = new List<int> { 1, 2, 3 };

            var result = ListOps.Concatenate(list);

            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Concatenate_ShouldReturnConcatenatedList_WhenMultipleListsArePassed()
        {

            var list1 = new List<int> { 1, 2 };
            var list2 = new List<int> { 3, 4 };
            var list3 = new List<int> { 5, 6 };

            var result = ListOps.Concatenate(list1, list2, list3);

            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6 }, result);
        }

        [TestMethod]
        public void Concatenate_ShouldReturnEmptyList_WhenAllInputListsAreEmpty()
        {
            var emptyList1 = new List<int>();
            var emptyList2 = new List<int>();

            var result = ListOps.Concatenate(emptyList1, emptyList2);

            CollectionAssert.AreEqual(new List<int>(), result);
        }
    }
}
