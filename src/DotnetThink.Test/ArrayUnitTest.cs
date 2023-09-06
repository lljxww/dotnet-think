namespace DotnetThink.Test
{
    public class ArrayUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MergeSortedArrayTest()
        {
            int[] nums1 = { 1, 2, 5 };
            int[] nums2 = { 2, 4 };

            new MergeSortedArray().Merge(nums1, 3, nums2, 2);

            Assert.Pass();
        }

        [Test]
        public void RotateTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            new RotateArray().Rotate(nums, k);

            Assert.That(3 == nums[5]);
        }
    }
}