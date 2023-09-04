namespace DotnetThink;

/// <summary>
/// 移除元素
/// </summary>
/// <seealso cref="https://leetcode.cn/problems/remove-element"/>
public class RemoveDuplicatesFromSortedArray2
{
    public int RemoveDuplicates(int[] nums, int val)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        int slow = 0, fast = 1, count = 1, maxCount = 2;

        while (fast < nums.Length)
        {
            if (nums[fast] > nums[slow])
            {
                nums[slow + 1] = nums[fast];
                slow++;
                count = 1;
            }
            else if (nums[fast] == nums[slow] && count != maxCount)
            {
                nums[slow + 1] = nums[fast];
                slow++;
                count++;
            }

            fast++;
        }

        return slow + 1;
    }
}
