

// Main
Node rootNode = new Node();
rootNode.data = 4;
BinarySerachTree.Insert(rootNode, 2);
BinarySerachTree.Insert(rootNode, 3);
BinarySerachTree.Insert(rootNode, 5);
BinarySerachTree.Insert(rootNode, 6);
BinarySerachTree.Insert(rootNode, 4);
/*
            4
        1       3
    8     9       6

*/
Console.WriteLine();
BinarySerachTree.PreorderTraversal(rootNode);
Console.WriteLine();
BinarySerachTree.InorderTraversal(rootNode);
Console.WriteLine();
BinarySerachTree.PostorderTraversal(rootNode);

/*
 * Implement search with Binary Search tree
            6
        4       8
    0    5         19

*/
/* 
            4
        1       3
    8     9       6

*/

Console.WriteLine("\n=================Binary Search Tree Find================");
Console.WriteLine("Is 3 in the tree? " + BinarySerachTree.Contains(rootNode, 3));
Console.WriteLine("Is 20 in the tree? " + BinarySerachTree.Contains(rootNode, 20));
public class Node
{
    public Node left { get; set; }
    public Node right { get; set; }
    public int data { get; set; }
}

public class BinarySerachTree
{
    public static bool Contains(Node root, int n)
    {
        if (root == null)
        {
            return false;
        }
        else if (n < root.data)
        {
            return Contains(root.left, n);
        }
        else if (n > root.data)
        {
            return Contains(root.right, n);
        }
        else if (n == root.data)
        {
            return true;
        }

        return false;


    }
    public static void PreorderTraversal(Node root)
    {
        if (root == null)
        {
            return;
        }
        Console.Write(root.data + " ");
        PreorderTraversal(root.left);
        PreorderTraversal(root.right);
    }
    public static void InorderTraversal(Node root)
    {
        if (root == null)
        {
            return;
        }
        InorderTraversal(root.left);
        Console.Write(root.data + " ");
        InorderTraversal(root.right);
    }

    public static void PostorderTraversal(Node root)
    {
        if (root == null)
        {
            return;
        }
        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        Console.Write(root.data + " ");
    }
    public static Node Insert(Node root, int value)
    {
        if (root == null)
        {
            root = new Node();
            root.data = value;
            return root;
        }
        else
        {
            if (value < root.data)
            {
                // insert on left
                root.left = Insert(root.left, value);
            }
            else
            {
                // insert right
                root.right = Insert(root.right, value);
            }
        }

        return root;
    }
}