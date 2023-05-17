using Assignment;

// Write tests ONLY for the ReplicateArray method. This method should not need any Console.ReadLine/Console.WriteLine statements.
// You should have at least three test cases
// 1. Empty Array (Done for you)
// 2. Array with a single element
// 3. Array with multiple elements
// Ensure the copied array has the same elements as the original array (CollectionAssert.AreEqual)
// Ensure that the new array is deep copied (Assert.AreNotSame)

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void ReplicateArray_EmptyArray_ReturnsEmptyArray()
        {
            int[] original = Array.Empty<int>();
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }

        [TestMethod]
        public void ReplicateArray_SingleElementArray_ReturnsSingleElementArray()
        {
            int[] original = new int[] { 1 };
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }

        [TestMethod]
        public void ReplicateArray_MultipleElementArray_ReturnsMultipleElementArray()
        {
            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] result = ArrayReplicator.ReplicateArray(original);
            CollectionAssert.AreEqual(original, result);
            Assert.AreNotSame(original, result);
        }
    }
}
