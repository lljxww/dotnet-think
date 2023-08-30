﻿namespace DotnetThink.DataStructure;

/// <summary>
/// 单链表节点
/// </summary>
public class ListNode
{
    public int val;

    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}