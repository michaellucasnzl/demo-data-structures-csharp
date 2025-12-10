/*
 * =============================================================================
 * DICTIONARY EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * Microsoft Learn Documentation:
 * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2
 * 
 * Dictionary<TKey, TValue> is a collection of key-value pairs with O(1) 
 * average-case lookup, insertion, and deletion. Keys must be unique.
 * 
 * This covers Dictionary and related types like SortedDictionary, 
 * ConcurrentDictionary, and ImmutableDictionary.
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create empty Dictionary<TKey, TValue>
 *    - Initialize with collection initializer
 *    - Create with custom IEqualityComparer
 *    - Create SortedDictionary (keeps keys sorted)
 * 
 * 2. Adding Elements
 *    - Add(key, value) - Throws if key exists
 *    - TryAdd(key, value) - Returns false if key exists
 *    - dict[key] = value - Adds or updates
 * 
 * 3. Retrieving Elements
 *    - dict[key] - Throws KeyNotFoundException if not found
 *    - TryGetValue(key, out value) - Safe retrieval
 *    - GetValueOrDefault(key) - Returns default if not found
 *    - ContainsKey(key) - Check if key exists
 *    - ContainsValue(value) - Check if value exists (O(n))
 * 
 * 4. Updating Elements
 *    - dict[key] = newValue - Update existing
 *    - Conditional update patterns
 * 
 * 5. Removing Elements
 *    - Remove(key) - Remove by key
 *    - Remove(key, out value) - Remove and get value
 *    - Clear() - Remove all
 * 
 * 6. Iteration
 *    - foreach KeyValuePair<TKey, TValue>
 *    - foreach key in dict.Keys
 *    - foreach value in dict.Values
 * 
 * 7. Properties
 *    - Count - Number of key-value pairs
 *    - Keys - Collection of keys
 *    - Values - Collection of values
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Word Frequency Counter
 *    Count occurrences of each word in a paragraph.
 *    Handle case-insensitivity and punctuation.
 * 
 * Exercise 2: LRU Cache
 *    Design a Least Recently Used cache with O(1) get and put.
 *    Hint: Combine Dictionary with LinkedList.
 * 
 * Exercise 3: Group By First Character
 *    Group a list of words by their first character.
 *    Example: ["apple","banana","apricot"] → {'a':["apple","apricot"],'b':["banana"]}
 * 
 * Exercise 4: Two Sum with Dictionary
 *    Use Dictionary to solve Two Sum in O(n) time.
 * 
 * Exercise 5: Clone Graph
 *    Clone a graph using Dictionary to map original to cloned nodes.
 * 
 * Exercise 6: Copy List with Random Pointer
 *    Clone a linked list where each node has a random pointer.
 *    Use Dictionary to map original nodes to copies.
 * 
 * Exercise 7: Find All Anagrams in String
 *    Find all start indices of anagrams of pattern p in string s.
 *    Example: s="cbaebabacd", p="abc" → [0, 6]
 * 
 * Exercise 8: Minimum Window Substring
 *    Find the minimum window in s that contains all characters of t.
 *    Example: s="ADOBECODEBANC", t="ABC" → "BANC"
 * 
 * Exercise 9: Time-Based Key-Value Store
 *    Create a key-value store where each key can have multiple values
 *    at different timestamps. Support get(key, timestamp).
 * 
 * Exercise 10: Design Twitter
 *    Design a simplified Twitter with: postTweet, getNewsFeed, 
 *    follow, and unfollow operations.
 * 
 * =============================================================================
 */

Console.WriteLine("=== Dictionary Exercises ===");
Console.WriteLine("Complete the exercises above to master C# Dictionary<TKey, TValue>!");
Console.WriteLine();

// Your code here...
