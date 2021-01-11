using System;
using System.Collections.Generic;
using System.Linq;

namespace ResultRoaster
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Number of students that sat for the exam.");

         int  students = new Random().Next(1,100);
         Console.WriteLine(students);

         int Pass = 0;
         int Average= 0;
         int fail = 0;

        List<int> scores = new List<int>();
        for(int i = 0; i< students; i++)
        {
            int score = new Random().Next(1,100);
            Console.WriteLine(score);
            if (score>= 70)
            {
                Pass = Pass + 1;
            }
            else if (score >= 50 && score<=69)
            {
                Average = Average + 1;
            }
            else if (score<50)
            {
                fail = fail + 1;
            }
            scores.Add(score);
        }
        Console.WriteLine("Here are the students that partook in the exam");
        Console.WriteLine("Students");
        Console.WriteLine("Here are the students that passed with a score of 70 and above");
         Console.WriteLine("Pass");
        Console.WriteLine("The students that got an average of 50 to 69");
        Console.WriteLine("Average");
        Console.WriteLine("Students who failed the exam by getting below 50");
        Console.WriteLine("fail");
        Console.WriteLine("Scores of all who partook");

        for (int i =0; i< students; i++)
        {
            Console.WriteLine(scores[i]);
        }
        }
    }
}
