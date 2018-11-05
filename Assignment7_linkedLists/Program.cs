using System;

namespace Assignment7_linkedLists
{
    

      
        class Program
    {
        // Recursive function to print the 
        // pattern without any extra variable 
        static void printPattern(int n)
        {

            // Base case (When n becomes 0 or 
            // negative) 
            if (n == 0 || n < 0)
            {

                Console.Write(n + " ");

                return;
            }

            // First print decreasing order 
            Console.Write(n + " ");

            printPattern(n - 5);

            // Then print increasing order 
            Console.Write(n + " ");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //FlattenLinkedList L = new FlattenLinkedList();

            //L.Head = L.push(L.Head, 30);
            //L.Head = L.push(L.Head, 8);
            //L.Head = L.push(L.Head, 7);
            //L.Head = L.push(L.Head, 5);

            //L.Head.Right = L.push(L.Head.Right, 20);
            //L.Head.Right = L.push(L.Head.Right, 10);

            // L.Head.Right.Right = L.push(L.Head.Right.Right, 50);
            //L.Head.Right.Right = L.push(L.Head.Right.Right, 22);
            //L.Head.Right.Right = L.push(L.Head.Right.Right, 19);

            //L.Head.Right.Right.Right = L.push(L.Head.Right.Right.Right, 35);
            //L.Head.Right.Right.Right = L.push(L.Head.Right.Right.Right, 40);
            //L.Head.Right.Right.Right = L.push(L.Head.Right.Right.Right, 35);
            //L.Head.Right.Right.Right = L.push(L.Head.Right.Right.Right, 20);

            // flatten the list 
            //L.Head = L.Flatten(L.Head);

            //L.PrintList();
            //int n = 16;

            //printPattern(n);
            ReverseKNodes llist = new ReverseKNodes();

            /* Constructed Linked List is 1->2->3->4->5->6-> 
               7->8->8->9->null */
            /** llist.push(9);
             llist.push(8);
             llist.push(7);
             llist.push(6);
             llist.push(5);
             llist.push(4);
             llist.push(3);
             llist.push(2);
             llist.push(1);

             Console.WriteLine("Given Linked List");
             llist.printList();

             llist.head = llist.Reverse(llist.head, 3);

             Console.WriteLine("Reversed list");
             llist.printList();**/
            MergeLists list = new MergeLists();
         
            var head1 = list.NewNode(1);
            
            head1.Next = list.NewNode(3);
            head1.Next.Next = list.NewNode(5);

            // 1->3->5 LinkedList created 
            var head2 = list.NewNode(0);

            head2.Next = list.NewNode(2);
            head2.Next.Next = list.NewNode(4);

        

        // 0->2->4 LinkedList created 

        var mergedhead = list.Merge(head1, head2);

        list.printList(mergedhead); 
     
            Console.ReadLine();
        }
    }
}
