using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7_linkedLists
{
    class MergeLists
    {
        public class Node
        {
            public int Data;
            public  Node Next;
            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        // Function to create newNode in a linkedlist 
       public Node NewNode(int key)
        {
             Node temp = new Node(key);             
            return temp; 
        }

    // A utility function to print linked list 
    public void printList(Node node)
    {
        while (node != null)
        {
            Console.WriteLine(node.Data);
            node = node.Next;
        }
    }

        // Merges two given lists in-place. This function 
        // mainly compares head nodes and calls mergeUtil() 
        // Merges two lists with headers as h1 and h2. 
        // It assumes that h1's data is smaller than 
        // or equal to h2's data. 
        public  Node MergeUtil(Node h1,  Node h2)
        { 
        
            // if only one node in first list 
            // simply point its head to second list 
            if (h1.Next == null) 
            { 
                h1.Next = h2; 
                return h1; 
            }

            // Initialize current and next pointers of 
            // both lists 
            Node curr1 = h1, next1 = h1.Next;
            Node curr2 = h2, next2 = h2.Next; 
  
            while (next1!=null && next2!=null) 
            { 
                // if curr2 lies in between curr1 and next1 
                // then do curr1->curr2->next1 
                if ((curr2.Data) > (curr1.Data) && 
                    (curr2.Data) < (next1.Data)) 
                { 
                    next2 = curr2.Next; 
                    curr1.Next = curr2; 
                    curr2.Next = next1; 
  
                    // now let curr1 and curr2 to point 
                    // to their immediate next pointers 
                    curr1 = curr2; 
                    curr2 = next2; 
                } 
                else
                { 
                    // if more nodes in first list 
                    if (next1.Next != null) 
                    { 
                        next1 = next1.Next; 
                        curr1 = curr1.Next; 
                    } 
  
                    // else point the last node of first list 
                    // to the remaining nodes of second list 
                    else
                    { 
                        next1.Next = curr2; 
                        return h1; 
                    } 
                } 
            } 
            return h1; 
         } 
  
// Merges two given lists in-place. This function 
// mainly compares head nodes and calls mergeUtil() 
            public Node Merge(Node h1, Node h2) 
            { 
                if (h1 == null) 
                    return h2; 
                if (h2 == null) 
                    return h1; 
  
                // start with the linked list 
                // whose head data is the least 
                if (h1.Data<h2.Data) 
                    return MergeUtil(h1, h2); 
                else
                    return MergeUtil(h2, h1); 
            } 
    }
}
