﻿using System;

namespace hackerank22
{
    class Program
    {
        static int getHeight(Node root){
            //Write your code here
            if (root == null || (root.right ==null && root.left==null)) {return 0;}
            else {return 1+ Math.Max(getHeight(root.right),getHeight(root.left));}
        }


        static Node insert(Node root, int data){
            if(root==null){
                return new Node(data);
            }
            else{
                Node cur;
                if(data<=root.data){
                    cur=insert(root.left,data);
                    root.left=cur;
                }
                else{
                    cur=insert(root.right,data);
                    root.right=cur;
                }
                return root;
            }
        }
        static void Main(String[] args){
            Node root=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                int data=Int32.Parse(Console.ReadLine());
                root=insert(root,data);            
            }
            int height=getHeight(root);
            Console.WriteLine(height);
        
        }
    }
    class Node{
        public Node left,right;
        public int data;
        public Node(int data){
            this.data=data;
            left=right=null;
        }
    }
    
    
}