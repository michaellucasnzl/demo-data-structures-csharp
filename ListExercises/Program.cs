/*
 * =============================================================================
 * LIST EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * Microsoft Learn Documentation:
 * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1
 * 
 * List<T> is a dynamic array that grows automatically. It provides O(1) access
 * by index, O(1) amortized addition at the end, but O(n) for insertion/removal
 * at arbitrary positions.
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create an empty List
 *    - Initialize with capacity
 *    - Initialize with collection initializer
 *    - Create from existing collection
 * 
 * 2. Adding Elements
 *    - Add(item) - Add to end
 *    - AddRange(collection) - Add multiple items
 *    - Insert(index, item) - Insert at position
 *    - InsertRange(index, collection) - Insert multiple at position
 * 
 * 3. Accessing Elements
 *    - list[index] - Access by index
 *    - First(), Last() - LINQ methods
 *    - ElementAt(index) - LINQ method
 * 
 * 4. Finding Elements
 *    - IndexOf(item) - Find first occurrence
 *    - LastIndexOf(item) - Find last occurrence
 *    - Find(predicate) - Find first matching
 *    - FindAll(predicate) - Find all matching
 *    - FindIndex(predicate) - Find index of first matching
 *    - Contains(item) - Check if exists
 *    - Exists(predicate) - Check if any matches
 *    - BinarySearch(item) - Binary search (list must be sorted)
 * 
 * 5. Removing Elements
 *    - Remove(item) - Remove first occurrence
 *    - RemoveAt(index) - Remove at index
 *    - RemoveRange(index, count) - Remove range
 *    - RemoveAll(predicate) - Remove all matching
 *    - Clear() - Remove all
 * 
 * 6. Other Operations
 *    - Sort() - Sort the list
 *    - Reverse() - Reverse order
 *    - ToArray() - Convert to array
 *    - GetRange(index, count) - Get sublist
 *    - CopyTo() - Copy to array
 *    - TrimExcess() - Reduce capacity to count
 * 
 * 7. Properties
 *    - Count - Number of elements
 *    - Capacity - Current capacity
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Merge Sorted Lists
 *    Merge two sorted lists into one sorted list.
 * 
 * Exercise 2: Remove Element
 *    Remove all occurrences of a value from a list and return new count.
 *    Do this in-place with O(1) extra space.
 * 
 * Exercise 3: Find All Pairs with Sum
 *    Find all pairs of elements that sum to a target value.
 * 
 * Exercise 4: Partition List
 *    Partition list so all elements less than x come before elements >= x.
 * 
 * Exercise 5: Flatten Nested List
 *    Given a list of lists, flatten into a single list.
 * 
 * Exercise 6: Find Peak Element
 *    A peak element is greater than its neighbors. Find any peak.
 *    Example: [1,2,3,1] → index 2 (element 3)
 * 
 * Exercise 7: Product of Array Except Self
 *    Return array where each element is product of all other elements.
 *    Example: [1,2,3,4] → [24,12,8,6]
 * 
 * Exercise 8: Three Sum
 *    Find all unique triplets that sum to zero.
 *    Example: [-1,0,1,2,-1,-4] → [[-1,-1,2],[-1,0,1]]
 * 
 * Exercise 9: Find Majority Element
 *    Find the element that appears more than n/2 times.
 *    Example: [3,2,3] → 3
 * 
 * Exercise 10: Spiral Matrix
 *    Given an m×n matrix, return elements in spiral order.
 *    Create a list from 2D array traversing in spiral pattern.
 * 
 * =============================================================================
 */

Console.WriteLine("=== List Exercises ===");
Console.WriteLine("Complete the exercises above to master C# List<T>!");
Console.WriteLine();

// Your code here...
