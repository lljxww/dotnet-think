namespace DotnetThink;

/// <summary>
/// 多数元素
/// </summary>
/// <seealso cref="https://leetcode.cn/problems/majority-element/submissions/"/>
public class MajorityElement
{
    public int MajorityElementMethod(int[] nums)
    {
        int target = (nums.Length / 2) + 1;
        Dictionary<int, int> res = new();
        int maxCount = 0, result = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (res.TryGetValue(nums[i], out int value))
            {
                res[nums[i]] = ++value;
                maxCount = maxCount > value ? maxCount : value;
                result = maxCount > value ? result : nums[i];

                if (value >= target)
                {
                    return nums[i];
                }
            }
            else
            {
                res.Add(nums[i], 1);
            }
        }

        return result;
    }
}
