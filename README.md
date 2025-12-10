# C# Data Structures

A comprehensive collection of C# console applications demonstrating various data structures. Each project contains exercises designed to help developers master these fundamental concepts.

## 📋 Overview

This repository contains 10 console applications, each focused on a specific data structure. Each project includes:
- Documentation of basic operations and methods
- 10 interview-style exercises ranging from basic to advanced
- Space for you to implement solutions

## 🎯 Purpose

1. **Learn** - Understand each data structure's operations and time complexities
2. **Practice** - Complete the exercises to reinforce your knowledge
3. **Reference** - Use your completed solutions as a quick refresher

## 📁 Projects

| Project | Data Structure | Key Concepts |
|---------|---------------|--------------|
| `ArrayExercises` | Array | Fixed-size, indexing, sorting, searching |
| `HashMapExercises` | HashMap (Dictionary) | Key-value pairs, O(1) lookup, hashing |
| `HashSetExercises` | HashSet | Unique elements, set operations |
| `ListExercises` | List&lt;T&gt; | Dynamic arrays, LINQ operations |
| `QueueExercises` | Queue&lt;T&gt; | FIFO, BFS, PriorityQueue |
| `StackExercises` | Stack&lt;T&gt; | LIFO, expression parsing, DFS |
| `TreeExercises` | Binary Tree / BST | Traversals, recursion, tree operations |
| `DictionaryExercises` | Dictionary&lt;TKey, TValue&gt; | Key-value storage, caching patterns |
| `LinkedListExercises` | LinkedList&lt;T&gt; | Node-based, two-pointer techniques |
| `SortedListExercises` | SortedList&lt;TKey, TValue&gt; | Sorted collections, range queries |

## 🚀 Getting Started

### Prerequisites
- .NET 8.0 SDK

### Running a Project

```bash
# Navigate to a project
cd ArrayExercises

# Run the project
dotnet run
```

### Running All Projects
```bash
# Build entire solution
dotnet build DataStructures.sln

# Run a specific project
dotnet run --project ArrayExercises
```

## 📝 How to Use

1. **Open a project's `Program.cs`** - Read the comments explaining the data structure
2. **Review basic operations** - Understand the available methods and their complexities
3. **Complete the exercises** - Implement solutions below the "Your code here" comment
4. **Test your solutions** - Run the project to verify your implementations
5. **Commit your work** - Save your solutions to the repository for future reference

## ⏱️ Time Complexity Quick Reference

| Data Structure | Access | Search | Insert | Delete |
|----------------|--------|--------|--------|--------|
| Array | O(1) | O(n) | O(n) | O(n) |
| List | O(1) | O(n) | O(1)* | O(n) |
| Dictionary | N/A | O(1) | O(1) | O(1) |
| HashSet | N/A | O(1) | O(1) | O(1) |
| Queue | O(n) | O(n) | O(1) | O(1) |
| Stack | O(n) | O(n) | O(1) | O(1) |
| LinkedList | O(n) | O(n) | O(1) | O(1) |
| SortedList | O(1) | O(log n) | O(n) | O(n) |
| BST (balanced) | O(log n) | O(log n) | O(log n) | O(log n) |

*Amortized for List.Add()

## 📚 Resources

- [Microsoft C# Collections Documentation](https://docs.microsoft.com/en-us/dotnet/standard/collections/)
- [Big-O Cheat Sheet](https://www.bigocheatsheet.com/)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
