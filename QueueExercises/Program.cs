/*
 * =============================================================================
 * QUEUE EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * Queue<T> is a First-In-First-Out (FIFO) collection. Elements are added at
 * the back and removed from the front. All operations are O(1).
 * 
 * Also covers PriorityQueue<TElement, TPriority> (added in .NET 6).
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create an empty Queue
 *    - Initialize from collection
 *    - Create PriorityQueue
 * 
 * 2. Adding Elements
 *    - Enqueue(item) - Add to back
 * 
 * 3. Removing Elements
 *    - Dequeue() - Remove and return front element (throws if empty)
 *    - TryDequeue(out result) - Safe dequeue
 *    - Clear() - Remove all elements
 * 
 * 4. Examining Elements
 *    - Peek() - View front element without removing (throws if empty)
 *    - TryPeek(out result) - Safe peek
 * 
 * 5. Other Operations
 *    - Contains(item) - Check if element exists (O(n))
 *    - ToArray() - Convert to array
 *    - CopyTo() - Copy to array
 * 
 * 6. Properties
 *    - Count - Number of elements
 * 
 * 7. PriorityQueue Operations
 *    - Enqueue(element, priority) - Add with priority
 *    - Dequeue() - Remove highest priority element
 *    - EnqueueDequeue(element, priority) - Efficient enqueue then dequeue
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Implement Stack using Queues
 *    Implement a stack (LIFO) using only queue operations.
 * 
 * Exercise 2: Generate Binary Numbers
 *    Generate binary representations of numbers 1 to n using a queue.
 *    Example: n=5 → ["1", "10", "11", "100", "101"]
 * 
 * Exercise 3: First Non-Repeating Character in Stream
 *    Given a stream of characters, find the first non-repeating character
 *    at any point in the stream.
 * 
 * Exercise 4: Level Order Traversal (BFS)
 *    Traverse a tree level by level using a queue.
 *    (This pairs with Tree exercises)
 * 
 * Exercise 5: Sliding Window Maximum
 *    Find the maximum element in each sliding window of size k.
 *    Example: [1,3,-1,-3,5,3,6,7], k=3 → [3,3,5,5,6,7]
 * 
 * Exercise 6: Implement Circular Queue
 *    Design a circular queue with fixed capacity.
 *    Support: enqueue, dequeue, front, rear, isEmpty, isFull
 * 
 * Exercise 7: Task Scheduler
 *    Given tasks with cooldown period, find minimum time to complete all.
 *    Tasks are represented by characters, same tasks need cooldown between them.
 * 
 * Exercise 8: Rotting Oranges
 *    In a grid, fresh oranges adjacent to rotten ones rot each minute.
 *    Find minimum minutes until no fresh oranges remain (or -1 if impossible).
 * 
 * Exercise 9: Number of Recent Calls
 *    Implement a class that counts requests in the last 3000 milliseconds.
 *    Each ping(t) adds a request at time t and returns count in [t-3000, t].
 * 
 * Exercise 10: Top K Frequent Elements (Priority Queue)
 *    Find the k most frequent elements in an array using PriorityQueue.
 *    Example: [1,1,1,2,2,3], k=2 → [1, 2]
 * 
 * =============================================================================
 */

Console.WriteLine("=== Queue Exercises ===");
Console.WriteLine("Complete the exercises above to master C# Queue<T>!");
Console.WriteLine();

// Your code here...
