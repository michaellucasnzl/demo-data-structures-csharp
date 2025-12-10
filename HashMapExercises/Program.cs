/*
 * =============================================================================
 * HASHMAP EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * Microsoft Learn Documentation:
 * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2
 * 
 * Note: C# doesn't have a "HashMap" class. The equivalent is Dictionary<TKey, TValue>
 * or Hashtable (non-generic, legacy). This exercise uses Dictionary which is the
 * modern, type-safe implementation of a hash map in C#.
 * 
 * Hash maps provide O(1) average-case lookup, insertion, and deletion.
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create an empty Dictionary
 *    - Initialize with collection initializer
 *    - Create from existing collection
 * 
 * 2. Adding Elements
 *    - Add(key, value) - Throws if key exists
 *    - TryAdd(key, value) - Returns false if key exists
 *    - dict[key] = value - Adds or updates
 * 
 * 3. Retrieving Elements
 *    - dict[key] - Throws if key doesn't exist
 *    - TryGetValue(key, out value) - Safe retrieval
 *    - ContainsKey(key) - Check if key exists
 *    - ContainsValue(value) - Check if value exists (O(n))
 * 
 * 4. Removing Elements
 *    - Remove(key) - Remove by key
 *    - Clear() - Remove all elements
 * 
 * 5. Iteration
 *    - Iterate over KeyValuePairs
 *    - Iterate over Keys only
 *    - Iterate over Values only
 * 
 * 6. Properties
 *    - Count - Number of elements
 *    - Keys - Collection of keys
 *    - Values - Collection of values
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Two Sum with HashMap
 *    Use a hash map to solve Two Sum in O(n) time.
 *    Given an array and target, return indices of two numbers that sum to target.
 * 
 * Exercise 2: First Non-Repeating Character
 *    Find the first character in a string that doesn't repeat.
 *    Example: "leetcode" → 'l', "loveleetcode" → 'v'
 * 
 * Exercise 3: Group Anagrams
 *    Given an array of strings, group anagrams together.
 *    Example: ["eat","tea","tan","ate","nat","bat"] → [["eat","tea","ate"],["tan","nat"],["bat"]]
 * 
 * Exercise 4: Character Frequency Counter
 *    Count the frequency of each character in a string.
 * 
 * Exercise 5: Valid Anagram
 *    Determine if two strings are anagrams of each other.
 *    Example: "anagram" and "nagaram" → true
 * 
 * Exercise 6: Find Duplicate in Array
 *    Use a hash map to find the first duplicate element in an array.
 * 
 * Exercise 7: Subarray Sum Equals K
 *    Find the total number of continuous subarrays whose sum equals k.
 *    Example: [1,1,1], k=2 → 2
 * 
 * Exercise 8: Longest Substring Without Repeating Characters
 *    Find the length of the longest substring without repeating characters.
 *    Example: "abcabcbb" → 3 ("abc")
 * 
 * Exercise 9: Word Pattern
 *    Given a pattern and a string, check if the string follows the pattern.
 *    Example: pattern="abba", s="dog cat cat dog" → true
 * 
 * Exercise 10: Isomorphic Strings
 *    Determine if two strings are isomorphic.
 *    Example: "egg" and "add" → true, "foo" and "bar" → false
 * 
 * =============================================================================
 */

Console.WriteLine("=== HashMap (Dictionary) Exercises ===");
Console.WriteLine("Complete the exercises above to master C# Dictionary/HashMap!");
Console.WriteLine();

// Your code here...
