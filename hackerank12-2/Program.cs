using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace hackerank12_2
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person()
        {
        }

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }


    class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores): base(firstName, lastName, id)
        {
            this.testScores = scores;
        }

        public char Calculate()
        {
            var totalScore = testScores.Sum();
            var average = totalScore / testScores.Length;
            char grade = '\0';
            
            if (average >= 90 && average <= 100) grade ='O';
            if (average >= 80 && average < 90) grade ='E';
            if (average >= 70 && average < 80) grade = 'A';
            if (average >= 55 && average < 70) grade ='P';
            if (average >= 40 && average < 55) grade = 'D';
            if (average < 40 && average >= 0) grade = 'T';
            return grade;
        } 
    }


    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}