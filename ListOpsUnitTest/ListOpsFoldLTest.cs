using Exercisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsFoldLTest
    {
        [TestMethod]
        public void Foldl_ShouldReturnInitialAccumulator_WhenInputListIsEmpty()
        {
            var emptyList = new List<int>();
            int initialAccumulator = 100;
            Func<int, int, int> function = (acc, x) => acc + x;

            var result = ListOps.Foldl(emptyList, initialAccumulator, function);

            Assert.AreEqual(initialAccumulator, result);
        }

        [TestMethod]
        public void Foldl_ShouldReturnFoldedResult_WhenInputListIsNotEmpty()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            int initialAccumulator = 10;
            Func<int, int, int> function = (acc, x) => acc * x;

            var result = ListOps.Foldl(list, initialAccumulator, function);

            Assert.AreEqual(1200, result); // ((((10 * 1) * 2) * 3) * 4) * 5
        }
    }
}
