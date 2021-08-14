using System;

namespace hackerank24
{
    class Node 
    {
        public int data; //integer data filed
        public Node next; // node instance pointer 
        public Node(int d){
            data=d;
            next=null;
        }
		
    }
    
    class Program
    {
        public static Node removeDuplicates(Node head){
            //Write your code here
    
        }
        static void Main(string[] args)
        {
            Node head=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                int data=Int32.Parse(Console.ReadLine());
                head=insert(head,data);
            }
            head=removeDuplicates(head);
            display(head);
        }
    }
}