using System.Transactions;

namespace DotnetThink;

public class MergeSortedArray
{
    /// <summary>
    /// 合并两个有序数组
    /// </summary>
    /// <param name="nums1"></param>
    /// <param name="m"></param>
    /// <param name="nums2"></param>
    /// <param name="n"></param>
    /// <seealso cref="https://leetcode.cn/problems/merge-sorted-array"/>
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (n == 0)
        {
            return;
        }

        if (m == 0)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
        }

        int cur = m + n - 1;
        m--;
        n--;

        while (cur >= 0)
        {
            if (m >= 0 && n >= 0)
            {
                if (nums1[m] > nums2[n])
                {
                    nums1[cur] = nums1[m];
                    m--;
                }
                else
                {
                    nums1[cur] = nums2[n];
                    n--;
                }
            }
            else if (n >= 0)
            {
                nums1[cur] = nums2[n];
                n--;
            }
            else
            {
                break;
            }

            cur--;
        }
    }
}
