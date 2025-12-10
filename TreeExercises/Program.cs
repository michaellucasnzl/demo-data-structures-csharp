/*
 * =============================================================================
 * TREE EXERCISES - C# Data Structures
 * =============================================================================
 * 
 * Trees are hierarchical data structures with a root node and child nodes.
 * Binary Trees have at most 2 children per node.
 * Binary Search Trees (BST) maintain ordering: left < parent < right.
 * 
 * C# doesn't have a built-in Tree class, so we implement our own.
 * 
 * =============================================================================
 * BASIC CONCEPTS TO UNDERSTAND:
 * =============================================================================
 * 
 * 1. Tree Terminology
 *    - Root: Top node with no parent
 *    - Leaf: Node with no children
 *    - Height: Longest path from node to a leaf
 *    - Depth: Path length from root to node
 *    - Level: All nodes at the same depth
 * 
 * 2. Binary Tree Node Structure
 *    public class TreeNode {
 *        public int Value;
 *        public TreeNode? Left;
 *        public TreeNode? Right;
 *        public TreeNode(int value) { Value = value; }
 *    }
 * 
 * 3. Tree Traversals
 *    - In-order (Left, Root, Right) - BST gives sorted order
 *    - Pre-order (Root, Left, Right) - Good for copying trees
 *    - Post-order (Left, Right, Root) - Good for deletion
 *    - Level-order (BFS) - Level by level using Queue
 * 
 * 4. Binary Search Tree (BST) Operations
 *    - Search: O(log n) average, O(n) worst
 *    - Insert: O(log n) average, O(n) worst
 *    - Delete: O(log n) average, O(n) worst
 * 
 * =============================================================================
 * BASIC OPERATIONS TO PRACTICE:
 * =============================================================================
 * 
 * 1. Build a Binary Tree from array representation
 * 2. Implement all four traversals (recursive and iterative)
 * 3. Insert a node in BST
 * 4. Search for a value in BST
 * 5. Delete a node from BST
 * 6. Find minimum and maximum in BST
 * 
 * =============================================================================
 * EXERCISES:
 * =============================================================================
 * 
 * Exercise 1: Maximum Depth of Binary Tree
 *    Find the maximum depth (height) of a binary tree.
 * 
 * Exercise 2: Validate Binary Search Tree
 *    Determine if a binary tree is a valid BST.
 * 
 * Exercise 3: Invert Binary Tree
 *    Mirror a binary tree (swap left and right children).
 * 
 * Exercise 4: Symmetric Tree
 *    Check if a binary tree is a mirror of itself.
 * 
 * Exercise 5: Lowest Common Ancestor
 *    Find the lowest common ancestor of two nodes in a BST.
 * 
 * Exercise 6: Path Sum
 *    Determine if tree has root-to-leaf path with target sum.
 * 
 * Exercise 7: Binary Tree Level Order Traversal
 *    Return values level by level as a list of lists.
 * 
 * Exercise 8: Convert Sorted Array to BST
 *    Convert a sorted array to a height-balanced BST.
 * 
 * Exercise 9: Serialize and Deserialize Binary Tree
 *    Design algorithm to serialize/deserialize a binary tree to/from string.
 * 
 * Exercise 10: Kth Smallest Element in BST
 *    Find the kth smallest element in a BST.
 * 
 * BONUS: Binary Tree Right Side View
 *    Return values visible from right side looking at the tree.
 * 
 * BONUS: Count Complete Tree Nodes
 *    Count nodes in a complete binary tree in less than O(n) time.
 * 
 * =============================================================================
 */

Console.WriteLine("=== Tree Exercises ===");
Console.WriteLine("Complete the exercises above to master Trees in C#!");
Console.WriteLine();

// Sample TreeNode class to get started:
public class TreeNode
{
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
    
    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

// Your code here...
