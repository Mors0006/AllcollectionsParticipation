using System;

namespace AllCollectionsParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classname = new string[3];
            Console.WriteLine("What is your first class course code?");
            string name1 = Console.ReadLine();
            Console.WriteLine("What is the course number for your first class?");
            string code1 = Console.ReadLine();
            Console.WriteLine("What is your second class course code?");
            string name2 = Console.ReadLine();
            Console.WriteLine("What is the course number for your second class?");
            string code2 = Console.ReadLine();
            Console.WriteLine("What is your third class course code?");
            string name3 = Console.ReadLine();
            Console.WriteLine("What is the course number for your third class?");
            string code3 = Console.ReadLine();
            classname[0] = name1;
            classname[1] = name2;
            classname[2] = name3;
            double codeone = Convert.ToDouble(code1);
            double codetwo = Convert.ToDouble(code2);
            double codethree = Convert.ToDouble(code3);
            double[] classcode = { codeone, codetwo, codethree };
            for (int i = 0; i < classname.Length; i++)
            {
                string code = classname[i];
                double number = classcode[i];
                Console.WriteLine($"{code}{number}");

            }
        }
    }
}
