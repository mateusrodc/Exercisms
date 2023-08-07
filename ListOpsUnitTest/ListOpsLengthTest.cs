using Exercisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsLengthTest
    {
        [TestMethod]
        public void Length_ShouldReturnZero_WhenInputListIsEmpty()
        {
            var emptyList = new List<int>();

            var result = ListOps.Length(emptyList);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Length_ShouldReturnCorrectLength_WhenInputListIsNotEmpty()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            var result = ListOps.Length(list);

            Assert.AreEqual(5, result);
        }
    }
}
