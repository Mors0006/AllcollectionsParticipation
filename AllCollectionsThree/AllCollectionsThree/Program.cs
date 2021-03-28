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
            coursegrades["MIS3013"].Add(.95);
            coursegrades["MIS3013"].Add(.70);
            coursegrades["MIS3013"].Add(.85);
            coursegrades.Add("MIS3023", new List<double>());
            coursegrades["MIS3023"].Add(.80);
            coursegrades["MIS3023"].Add(.75);
            coursegrades["MIS3023"].Add(.60);
            coursegrades.Add("MIS3033", new List<double>());
            coursegrades["MIS3033"].Add(.90);
            coursegrades["MIS3033"].Add(.77);
            coursegrades["MIS3033"].Add(.69);
            double grade = 0;
            Console.WriteLine("Which class do you want to see the average grade for? MIS3013, MIS3023 or MIS3033?");
            string courseid = Console.ReadLine();
            Random rand = new Random();
            foreach (string coursename in coursegrades.Keys)
            {
                if (coursegrades.ContainsKey(courseid))
                {
                    List<double> grades = coursegrades[courseid];


                }
                else
                {
                    Console.WriteLine($"{courseid} is not a valid course id. Be more careful next time!");
                    Environment.Exit(-1);
                }
                for (int i = 0; i < coursename.Length; i++)
                {
                    if (coursegrades.ContainsKey(courseid) != false)
                    {
                        grade = coursegrades[courseid];
                    }

                }


            }
            

            // I am totally lost and gave up

        }
    }
}
