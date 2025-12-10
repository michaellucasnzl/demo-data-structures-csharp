/*
 * =============================================================================
 * SORTEDLIST EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * SortedList<TKey, TValue> is a collection of key-value pairs sorted by key.
 * It uses less memory than SortedDictionary but has slower insertion/removal
 * for unsorted data. Access by index is O(1), but insertion is O(n).
 * 
 * Also covers SortedSet<T> and SortedDictionary<TKey, TValue>.
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create empty SortedList<TKey, TValue>
 *    - Initialize with custom IComparer
 *    - Create SortedSet<T>
 *    - Create SortedDictionary<TKey, TValue>
 * 
 * 2. Adding Elements
 *    - Add(key, value) - Throws if key exists
 *    - TryAdd(key, value) - Returns false if key exists
 *    - list[key] = value - Adds or updates
 * 
 * 3. Retrieving Elements
 *    - list[key] - Access by key
 *    - GetKeyAtIndex(index) - Access key by index
 *    - GetValueAtIndex(index) - Access value by index
 *    - TryGetValue(key, out value) - Safe retrieval
 *    - ContainsKey(key) - Check if key exists
 *    - ContainsValue(value) - Check if value exists
 *    - IndexOfKey(key) - Get index of key
 *    - IndexOfValue(value) - Get index of value
 * 
 * 4. Removing Elements
 *    - Remove(key) - Remove by key
 *    - RemoveAt(index) - Remove at index
 *    - Clear() - Remove all
 * 
 * 5. Properties
 *    - Count - Number of elements
 *    - Keys - Sorted collection of keys
 *    - Values - Collection of values (in key order)
 *    - Capacity - Current capacity
 * 
 * =============================================================================
 * SORTEDSET OPERATIONS:
 * =============================================================================
 * 
 * - Add(item) - Add element
 * - Remove(item) - Remove element
 * - Contains(item) - Check existence
 * - Min, Max - Get min/max elements
 * - GetViewBetween(lower, upper) - Get subset view
 * - Reverse() - Iterate in reverse order
 * - Set operations: UnionWith, IntersectWith, ExceptWith
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Find Kth Largest Element
 *    Use a sorted collection to find the kth largest element.
 *    Example: [3,2,1,5,6,4], k=2 → 5
 * 
 * Exercise 2: Merge K Sorted Lists
 *    Merge k sorted lists into one sorted list.
 * 
 * Exercise 3: Meeting Rooms II
 *    Given meeting time intervals, find minimum conference rooms required.
 *    Example: [[0,30],[5,10],[15,20]] → 2
 * 
 * Exercise 4: Top K Frequent Words
 *    Find the k most frequent words, sorted by frequency then alphabetically.
 * 
 * Exercise 5: Range Sum Query - Mutable
 *    Implement a data structure for range sum queries with updates.
 *    Support: update(index, value) and sumRange(left, right)
 * 
 * Exercise 6: Contains Duplicate III
 *    Check if there are two distinct indices i and j where:
 *    - |nums[i] - nums[j]| <= valueDiff
 *    - |i - j| <= indexDiff
 * 
 * Exercise 7: My Calendar I
 *    Implement a calendar that prevents double booking.
 *    Support: book(start, end) returns true if event can be added.
 * 
 * Exercise 8: Data Stream as Disjoint Intervals
 *    Given a data stream, return summary as disjoint intervals.
 *    Example: add 1,3,7,2,6 → [[1,3],[6,7]]
 * 
 * Exercise 9: Count of Smaller Numbers After Self
 *    For each element, count elements to its right that are smaller.
 *    Example: [5,2,6,1] → [2,1,1,0]
 * 
 * Exercise 10: Skyline Problem
 *    Given buildings [left, right, height], compute the skyline.
 *    Return key points where height changes.
 * 
 * =============================================================================
 */

Console.WriteLine("=== SortedList Exercises ===");
Console.WriteLine("Complete the exercises above to master C# SortedList<TKey, TValue>!");
Console.WriteLine();

// Your code here...
