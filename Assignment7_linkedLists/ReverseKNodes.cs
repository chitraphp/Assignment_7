﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7_linkedLists
{
    class ReverseKNodes
    {

        // Java program to reverse a linked list in groups of 
        // given size 

        public Node head;  // head of list 

        /* Linked list Node*/
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; next = null; }
        }

        public Node Reverse(Node head, int k)
        {
            Node current = head;
            Node next = null;
            Node prev = null;


            int count = 0;

            /* Reverse first k nodes of linked list */
            while (count < k && current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count++;
            }

            /* next is now a pointer to (k+1)th node  
               Recursively call for the list starting from current. 
               And make rest of the list as next of first node */
            if (next != null)
                head.next = Reverse(next, k);

            // prev is now head of input list 
            return prev;
        }


        /* Utility functions */

        /* Inserts a new Node at front of the list. */
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node & 
                      Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        /* Function to print linked list */
        public void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}
