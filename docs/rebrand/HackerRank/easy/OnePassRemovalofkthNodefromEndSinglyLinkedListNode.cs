// One-Pass Removal of k-th Node from End

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class OnePassRemovalofkthNodefromEndSinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;

    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public SinglyLinkedListNode head;
    public SinglyLinkedListNode tail;

    public SinglyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void InsertNode(int nodeData)
    {
        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            this.tail.next = node;
        }

        this.tail = node;
    }
}

class SinglyLinkedListPrintHelepr
{
    public static void PrintList(SinglyLinkedListNode node, string sep)
    {
        while (node != null)
        {
            Console.Write(node.data);

            node = node.next;

            if (node != null)
            {
                Console.Write(sep);
            }
        }
    }
}



class Result
{

    /*
     * Complete the 'removeKthNodeFromEnd' function below.
     *
     * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
     * The function accepts following parameters:
     *  1. INTEGER_SINGLY_LINKED_LIST head
     *  2. INTEGER k
     */

    /*
     * For your reference:
     *
     * SinglyLinkedListNode
     * {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */

    public static SinglyLinkedListNode removeKthNodeFromEnd(SinglyLinkedListNode head, int k)
    {            
        int tail = 0;
        
        Search(head, head.next, k, 0, ref tail);
        
        return k == tail ? head.next : head;
    }
    
    static void Search(SinglyLinkedListNode head, SinglyLinkedListNode next, int k, int pos, ref int tail)
    {
        if (next == null)
        {
            tail = pos;
            return;            
        } 
                
        Search(next, next.next, k, pos + 1, ref tail);
        
        // Console.WriteLine($"h: {head.data}, k:{k}, pos:{pos}, tail: {tail}");
        
        if (tail - pos - 1 == k) {
            head.next = next.next;
        }
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {
        SinglyLinkedList head = new SinglyLinkedList();

        int headCount = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < headCount; i++)
        {
            int headItem = Convert.ToInt32(Console.ReadLine().Trim());
            head.InsertNode(headItem);
        }

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        SinglyLinkedListNode result = Result.removeKthNodeFromEnd(head.head, k);

        SinglyLinkedListPrintHelepr.PrintList(result, "\n");
        Console.WriteLine();
    }
}
