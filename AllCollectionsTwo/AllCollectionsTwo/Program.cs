using System;
using System.Collections.Generic;

namespace AllCollectionsTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            List<double> gradeScores = new List<double>();
            

            do
            {
                Console.WriteLine("Enter your grade: >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer);
                gradeScores.Add(score);

                Console.WriteLine("Do you have another exam score to enter, yes or no? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');
            double sum = 0;
            foreach (double score in gradeScores)
            {
                sum += score;
            }
            double average = sum / gradeScores.Count;
            Console.WriteLine($"Your average grade is {average}");


        }
    }
}
