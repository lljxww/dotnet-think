namespace DotnetThink;

/// <summary>
/// 轮转数组
/// </summary>
/// <seealso cref="https://leetcode.cn/problems/rotate-array/"/>
public class RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;

        // 原地不动
        if (nums.Length == k)
        {
            return;
        }

        Reserve(nums, 0, nums.Length - k - 1);
        Reserve(nums, nums.Length - k, nums.Length - 1);
        Reserve(nums, 0, nums.Length - 1);
    }

    /// <summary>
    /// 翻转数组中指定起止点间的数据（包含起止点）
    /// </summary>
    /// <param name="nums">要操作的数组</param>
    /// <param name="start">起点（含）</param>
    /// <param name="end">终点（含）</param>
    private void Reserve(int[] nums, int start, int end)
    {
        if (nums == null || nums.Length == 0)
        {
            return;
        }

        start = start < 0 ? 0 : start;
        end = end > nums.Length ? nums.Length : end;

        if (start >= end)
        {
            return;
        }

        while (start < end)
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;

            start++;
            end--;
        }
    }
}
