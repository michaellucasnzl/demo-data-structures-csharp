/*
 * =============================================================================
 * HASHSET EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * HashSet<T> is a collection of unique elements with O(1) average-case 
 * lookup, insertion, and deletion. It implements set operations like
 * union, intersection, and difference.
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create an empty HashSet
 *    - Initialize with collection initializer
 *    - Create from existing collection (removes duplicates)
 * 
 * 2. Adding Elements
 *    - Add(item) - Returns true if added, false if already exists
 * 
 * 3. Checking Elements
 *    - Contains(item) - Check if element exists
 * 
 * 4. Removing Elements
 *    - Remove(item) - Remove specific element
 *    - RemoveWhere(predicate) - Remove matching elements
 *    - Clear() - Remove all elements
 * 
 * 5. Set Operations
 *    - UnionWith() - Add all elements from another collection
 *    - IntersectWith() - Keep only common elements
 *    - ExceptWith() - Remove elements that exist in another collection
 *    - SymmetricExceptWith() - Keep elements in either but not both
 *    - IsSubsetOf() - Check if subset
 *    - IsSupersetOf() - Check if superset
 *    - Overlaps() - Check if any common elements
 *    - SetEquals() - Check if same elements
 * 
 * 6. Properties
 *    - Count - Number of elements
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Remove Duplicates
 *    Given an array with duplicates, return an array with unique elements only.
 *    Example: [1, 2, 2, 3, 4, 4, 5] → [1, 2, 3, 4, 5]
 * 
 * Exercise 2: Find Intersection of Two Arrays
 *    Find common elements between two arrays.
 *    Example: [1,2,2,1] and [2,2] → [2]
 * 
 * Exercise 3: Find Union of Two Arrays
 *    Combine two arrays and remove duplicates.
 * 
 * Exercise 4: Find Difference
 *    Find elements in first array but not in second.
 * 
 * Exercise 5: Contains Duplicate
 *    Check if an array contains any duplicates.
 *    Example: [1,2,3,1] → true, [1,2,3,4] → false
 * 
 * Exercise 6: Happy Number
 *    Determine if a number is "happy". A happy number eventually reaches 1
 *    when replaced by the sum of squares of its digits.
 *    Example: 19 → 1² + 9² = 82 → 8² + 2² = 68 → ... → 1 (happy)
 * 
 * Exercise 7: Single Number
 *    Find the element that appears only once (all others appear twice).
 *    Example: [4,1,2,1,2] → 4
 * 
 * Exercise 8: Longest Consecutive Sequence
 *    Find the length of the longest consecutive elements sequence.
 *    Example: [100, 4, 200, 1, 3, 2] → 4 (sequence: 1, 2, 3, 4)
 * 
 * Exercise 9: Find Missing Numbers in Range
 *    Given an array of integers in range [1, n], find all missing numbers.
 *    Example: [4,3,2,7,8,2,3,1], n=8 → [5, 6]
 * 
 * Exercise 10: Word Ladder Length
 *    Given two words and a dictionary, find shortest transformation sequence length.
 *    Each step changes one letter, and each intermediate word must be in dictionary.
 * 
 * =============================================================================
 */

Console.WriteLine("=== HashSet Exercises ===");
Console.WriteLine("Complete the exercises above to master C# HashSet!");
Console.WriteLine();

// Your code here...
