using System;

namespace BSTtoDoubleLinkList
{
    class Program
    {
        static Node head;
        static Node last = null;
        static Node first = null;
        static void Main(string[] args)
        {
            head = new Node();
            Node root = new Node(4);
            root.left = new Node(2);
            root.right = new Node(5);
            root.left.left = new Node(1);
            root.left.right = new Node(3);
            var t = TreeToDoublyList(root);
            Console.ReadKey();
        }

        private static object TreeToDoublyList(Node root)
        {
            if (root == null) return null;
            if (root.left == null && root.right == null) return root;
            helper(root);
            last.right = first;
            first.left = last;
            return first;
        }

        private static void helper(Node node)
        {
            if (node != null)
            {
                helper(node.left);
                if (last == null)
                {
                    first = node;
                }
                else
                {
                    last.right = node;
                    node.left = last;
                }
                last = node;
                helper(node.right);
            }
        }
        //public static Node TreeToDoublyList(Node root)
        //{
        //    if (root == null) return null;
        //    if (root.left == null && root.right == null) return root;
        //    Node newNode = new Node(root.val);
        //    newNode.left = TreeToDoublyList(root.left);
        //    newNode.right = TreeToDoublyList(root.right);
        //    root.left = newNode.left;
        //    root.right = newNode.right;
        //    head = newNode.left;
        //    return head;
        //}
    }
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node() { }
        public Node(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }
        public Node(int _val, Node _left, Node _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}
