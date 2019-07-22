using System;
using System.Text.RegularExpressions;
using ExamPaper.entity;

namespace ExamPaper
{
    class Program
    {
        static void Main(string[] args)
        {
          Example1();
        }

        public static void Example1()
        {
            var people = new People{Name = "Mary", Gender = true, Age = 25};
            Console.WriteLine("Simple Properties Demo");
            Console.WriteLine("Person details: "+people.ToString());
            people.Age = 35;
            Console.WriteLine("Person details (apter incrementing age):"+ people.ToString());
        }

        public static void Example2()
        {
            Console.WriteLine("Enter a String");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            var word = Console.ReadLine();

            var count = Regex.Matches(str, word).Count;
            Console.WriteLine($"Word found {count} times in the string");

        }
        
    }
}