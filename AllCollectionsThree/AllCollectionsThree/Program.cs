using System;
using System.Collections.Generic;

namespace AllCollectionsThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> coursegrades = new Dictionary<string, List<double>>();
            coursegrades.Add("MIS3013", new List<double>());
            coursegrades["MIS3013"].Add(95);
            coursegrades["MIS3013"].Add(70);
            coursegrades["MIS3013"].Add(85);
            coursegrades.Add("MIS3023", new List<double>());
            coursegrades["MIS3023"].Add(80);
            coursegrades["MIS3023"].Add(75);
            coursegrades["MIS3023"].Add(60);
            coursegrades.Add("MIS3033", new List<double>());
            coursegrades["MIS3033"].Add(90);
            coursegrades["MIS3033"].Add(77);
            coursegrades["MIS3033"].Add(69);
            
            
            
            foreach (string coursename in coursegrades.Keys)
            {
                    double sum = 0;
                    List<double> grades = coursegrades[coursename];
                    foreach (double score in grades)
                    {
                        sum = sum + score;
                    }
                    double average = sum / grades.Count;
                    double percent = average / 100;
                    Console.WriteLine($"For {coursename}, your average grade is" +
                        $" {percent.ToString("P2")}");

               


            }
            

            

        }
    }
}
