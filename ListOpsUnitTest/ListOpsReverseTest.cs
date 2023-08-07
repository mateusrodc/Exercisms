using Exercisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismTesting
{
    [TestClass]
    public class ListOpsReverseTest
    {
        [TestMethod]
        public void Reverse_ShouldReturnEmptyList_WhenInputIsEmpty()
        {
            List<int> inputList = new List<int>();

            var result = ListOps.Reverse(inputList);

            CollectionAssert.AreEqual(inputList, result);
        }
        [TestMethod]
        public void Reverse_ShouldReturnReversedIntList_WhenInputIsIntList()
        {
            List<int> inputList = new List<int> { 1, 2, 3, 4, 5 };

            List<int> result = ListOps.Reverse(inputList);

            CollectionAssert.AreEqual(new List<int> { 5, 4, 3, 2, 1 }, result);
        }
        [TestMethod]
        public void Reverse_ShouldReturnReversedStringList_WhenInputIsStringList()
        {
            List<string> inputList = new List<string> { "apple", "banana", "orange" };

            List<string> result = ListOps.Reverse(inputList);

            CollectionAssert.AreEqual(new List<string> { "orange", "banana", "apple" }, result);
        }
        [TestMethod]
        public void Reverse_ShouldReturnReversedListOfCustomObjects_WhenInputIsCustomObjectList()
        {
            var inputList = new List<CustomObject>
            {
                new CustomObject { Id = 1, Name = "Object 1" },
                new CustomObject { Id = 2, Name = "Object 2" },
                new CustomObject { Id = 3, Name = "Object 3" }
            };

            var result = ListOps.Reverse(inputList);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("Object 3", result[0].Name);
            Assert.AreEqual("Object 2", result[1].Name);
            Assert.AreEqual("Object 1", result[2].Name);
            Assert.AreEqual(3, result[0].Id);
            Assert.AreEqual(2, result[1].Id);
            Assert.AreEqual(1, result[2].Id);
        }
        public class CustomObject
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
