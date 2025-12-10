/*
 * =============================================================================
 * LINKEDLIST EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * Microsoft Learn Documentation:
 * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1
 * 
 * LinkedList<T> is a doubly-linked list with O(1) insertion/deletion at known
 * positions, but O(n) access by index. Each node has Previous and Next pointers.
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create empty LinkedList<T>
 *    - Initialize from collection
 * 
 * 2. Adding Elements
 *    - AddFirst(value) - Add to beginning
 *    - AddLast(value) - Add to end
 *    - AddBefore(node, value) - Add before specific node
 *    - AddAfter(node, value) - Add after specific node
 * 
 * 3. Accessing Elements
 *    - First - First node
 *    - Last - Last node
 *    - node.Value - Get value
 *    - node.Next - Next node
 *    - node.Previous - Previous node
 * 
 * 4. Finding Elements
 *    - Find(value) - Find first occurrence
 *    - FindLast(value) - Find last occurrence
 *    - Contains(value) - Check if exists
 * 
 * 5. Removing Elements
 *    - RemoveFirst() - Remove first node
 *    - RemoveLast() - Remove last node
 *    - Remove(value) - Remove first occurrence
 *    - Remove(node) - Remove specific node
 *    - Clear() - Remove all nodes
 * 
 * 6. Properties
 *    - Count - Number of nodes
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Reverse a Linked List
 *    Reverse a singly linked list in-place.
 *    Implement both iterative and recursive solutions.
 * 
 * Exercise 2: Detect Cycle
 *    Determine if a linked list has a cycle.
 *    Use Floyd's Cycle Detection (slow/fast pointers).
 * 
 * Exercise 3: Find Cycle Start
 *    If a cycle exists, find the node where the cycle begins.
 * 
 * Exercise 4: Merge Two Sorted Lists
 *    Merge two sorted linked lists into one sorted list.
 * 
 * Exercise 5: Remove Nth Node From End
 *    Remove the nth node from the end in one pass.
 *    Example: [1,2,3,4,5], n=2 → [1,2,3,5]
 * 
 * Exercise 6: Find Middle Node
 *    Find the middle node of a linked list in one pass.
 *    For even length, return the second middle node.
 * 
 * Exercise 7: Palindrome Linked List
 *    Check if a linked list is a palindrome.
 *    Example: [1,2,2,1] → true, [1,2] → false
 * 
 * Exercise 8: Intersection of Two Lists
 *    Find the node where two singly linked lists intersect.
 * 
 * Exercise 9: Add Two Numbers
 *    Numbers are stored in reverse order in linked lists.
 *    Add them and return the sum as a linked list.
 *    Example: (2→4→3) + (5→6→4) = (7→0→8) representing 342 + 465 = 807
 * 
 * Exercise 10: Flatten a Multilevel Doubly Linked List
 *    Flatten a list where nodes may have child lists.
 * 
 * BONUS: Implement your own singly linked list from scratch with:
 *    - InsertAtHead, InsertAtTail, InsertAt(index)
 *    - DeleteAtHead, DeleteAtTail, DeleteAt(index)
 *    - Search, GetAt(index), Print
 * 
 * =============================================================================
 */

Console.WriteLine("=== LinkedList Exercises ===");
Console.WriteLine("Complete the exercises above to master C# LinkedList<T>!");
Console.WriteLine();

// Sample ListNode class for singly linked list problems:
public class ListNode
{
    public int Value { get; set; }
    public ListNode? Next { get; set; }
    
    public ListNode(int value)
    {
        Value = value;
        Next = null;
    }
}

// Your code here...
