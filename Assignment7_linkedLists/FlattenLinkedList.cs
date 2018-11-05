using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7_linkedLists
{
    
    
    class FlattenLinkedList
    {
        public Node Head;
        public class Node
        {
            public Node Right;
            public Node Down;
            public int Data;

            public Node(int data)
            {
                this.Data = data;
                this.Right = null;
                this.Down = null;
            }
        }

        public Node merge(Node a, Node b)
        {
            // if first linked list is empty then second 
            // is the answer 
            if (a == null) return b;

            // if second linked list is empty then first 
            // is the result 
            if (b == null) return a;

            // compare the data members of the two linked lists 
            // and put the larger one in the result 
            Node result;

            if (a.Data < b.Data)
            {
                result = a;
                result.Down = merge(a.Down, b);
            }

            else
            {
                result = b;
                result.Down = merge(a, b.Down);
            }

            return result;
        }

        public Node Flatten(Node root)
        {
            // Base Cases 
            if (root == null || root.Right == null)
                return root;

            // recur for list on right 
            root.Right = Flatten(root.Right);

            // now merge 
            root = merge(root, root.Right);

            // return the root 
            // it will be in turn merged with its left 
            return root;
        }

        /* Utility function to insert a node at begining of the 
	linked list */
        public Node push(Node Head_ref, int data)
        {
            /* 1 & 2: Allocate the Node & 
                    Put in the data*/
            Node new_node = new Node(data);

            /* 3. Make next of new Node as Head */
            new_node.Down = Head_ref;

            /* 4. Move the Head to point to new Node */
            Head_ref = new_node;

            /*5. return to link it back */
            return Head_ref;
        }

        public void PrintList()
        {

            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");                
                temp = temp.Down;
            }
            Console.WriteLine();
            
        }


    }
}
