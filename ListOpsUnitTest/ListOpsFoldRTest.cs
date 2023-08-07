using Exercisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsFoldRTest
    {
        [TestMethod]
        public void Foldr_ShouldReturnInitialAccumulator_WhenInputListIsEmpty()
        {
            var emptyList = new List<int>();
            int initialAccumulator = 100;
            Func<int, int, int> function = (x, acc) => x + acc;

            var result = ListOps.Foldr(emptyList, initialAccumulator, function);

            Assert.AreEqual(initialAccumulator, result);
        }

        [TestMethod]
        public void Foldr_ShouldReturnFoldedResult_WhenInputListIsNotEmpty()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            int initialAccumulator = 10;
            Func<int, int, int> function = (x, acc) => x * acc;

            var result = ListOps.Foldr(list, initialAccumulator, function);

            Assert.AreEqual(1200, result); // (1 * (2 * (3 * (4 * (5 * 10)))))
        }
    }
}
