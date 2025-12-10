/*
 * =============================================================================
 * STACK EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * Microsoft Learn Documentation:
 * https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1
 * 
 * Stack<T> is a Last-In-First-Out (LIFO) collection. Elements are added and
 * removed from the same end (top). All operations are O(1).
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Declaration & Initialization
 *    - Create an empty Stack
 *    - Initialize from collection
 * 
 * 2. Adding Elements
 *    - Push(item) - Add to top
 * 
 * 3. Removing Elements
 *    - Pop() - Remove and return top element (throws if empty)
 *    - TryPop(out result) - Safe pop
 *    - Clear() - Remove all elements
 * 
 * 4. Examining Elements
 *    - Peek() - View top element without removing (throws if empty)
 *    - TryPeek(out result) - Safe peek
 * 
 * 5. Other Operations
 *    - Contains(item) - Check if element exists (O(n))
 *    - ToArray() - Convert to array (top element at index 0)
 *    - CopyTo() - Copy to array
 * 
 * 6. Properties
 *    - Count - Number of elements
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Valid Parentheses
 *    Check if a string of brackets is valid.
 *    Example: "()[]{}" → true, "([)]" → false, "{[]}" → true
 * 
 * Exercise 2: Reverse a String
 *    Use a stack to reverse a string.
 * 
 * Exercise 3: Implement Queue using Stacks
 *    Implement a queue (FIFO) using only stack operations.
 * 
 * Exercise 4: Min Stack
 *    Design a stack that supports push, pop, top, and getMin in O(1).
 * 
 * Exercise 5: Evaluate Reverse Polish Notation
 *    Evaluate an arithmetic expression in Reverse Polish Notation.
 *    Example: ["2","1","+","3","*"] → 9 ((2+1)*3)
 * 
 * Exercise 6: Daily Temperatures
 *    Given daily temperatures, find days until a warmer temperature.
 *    Example: [73,74,75,71,69,72,76,73] → [1,1,4,2,1,1,0,0]
 * 
 * Exercise 7: Decode String
 *    Decode an encoded string with pattern k[encoded_string].
 *    Example: "3[a]2[bc]" → "aaabcbc", "2[a2[b]]" → "abbabb"
 * 
 * Exercise 8: Next Greater Element
 *    Find the next greater element for each element in an array.
 *    Example: [4,1,2] → [-1,2,-1] (no greater for 4, 2 for 1, no greater for 2)
 * 
 * Exercise 9: Largest Rectangle in Histogram
 *    Find the largest rectangular area in a histogram.
 *    Example: heights = [2,1,5,6,2,3] → 10 (5×2 rectangle)
 * 
 * Exercise 10: Basic Calculator
 *    Implement a basic calculator to evaluate a string expression.
 *    Support: +, -, (, ), and spaces.
 *    Example: "(1+(4+5+2)-3)+(6+8)" → 23
 * 
 * =============================================================================
 */

Console.WriteLine("=== Stack Exercises ===");
Console.WriteLine("Complete the exercises above to master C# Stack<T>!");
Console.WriteLine();

// Your code here...
