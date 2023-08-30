using DotnetThink.DataStructure;

namespace DotnetThink.LinkedList;

public class RemoveLinkedListElements
{
    /// <summary>
    /// 移除链表元素
    /// </summary>
    /// <param name="head"></param>
    /// <param name="val"></param>
    /// <remarks>时间复杂度：O(n) 空间复杂度：O(1)</remarks>
    /// <seealso href="https://leetcode.cn/problems/remove-linked-list-elements/">移除链表元素</seealso>
    /// <returns></returns>
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode newHead = new(-1, head);
        ListNode current = newHead;

        while (current.next != null)
        {
            if (current.next.val == val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return newHead.next;
    }
}

/*
 * 通过创建一个虚拟头节点，帮助减少逻辑处理：
 * 1. 在删除目标节点（尤其是目标节点是给定链表的头节点时）带来便利；
 * 2. 避免循环遍历时的首次遍历条件的判断
 */
