﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace hackerank13
{
    abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }

        public abstract void display();
    }

    class MyBook : Book
    {
        private int Price;
        public MyBook(String title, String author, int price):base(title,author)
        {
            Price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Price: {0}", Price);
        }

    }


    class Program
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}