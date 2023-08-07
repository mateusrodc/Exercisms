using Exercisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsAppendTest
    {
        [TestMethod]
        public void Append_ShouldAddElementsOfSecondListToFirstList()
        {
            // Arrange
            var first = new List<int> { 1, 2, 3 };
            var second = new List<int> { 4, 5, 6 };

            // Act
            var result = ListOps.Append(first, second);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6 }, result);
        }

        [TestMethod]
        public void Append_ShouldReturnFirstListWhenSecondListIsEmpty()
        {
            // Arrange
            var first = new List<int> { 1, 2, 3 };
            var second = new List<int>();

            // Act
            var result = ListOps.Append(first, second);

            // Assert
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result);
        }

        [TestMethod]
        public void Append_ShouldReturnNewListWithElementsOfFirstListWhenSecondListIsEmpty()
        {
            // Arrange
            var first = new List<int> { 1, 2, 3 };
            var second = new List<int>();

            // Act
            var result = ListOps.Append(first, second);

            // Assert
            CollectionAssert.AreEqual(first, result);
        }
    }
}
