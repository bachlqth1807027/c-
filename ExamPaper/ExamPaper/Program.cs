using System;
using ExamPaper.entity;

namespace ExamPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People()
            {
               Name = "Marry",
               Gender = "Male",
               Age = 25,
            };

            Console.WriteLine(people);
            people.Age = 35;
            Console.WriteLine("Person details (Apter incrementing age) : " + people);
        }
    }
}