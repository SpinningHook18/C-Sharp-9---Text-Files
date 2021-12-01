using System;
using System.IO;

namespace C_Sharp_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = -999999;
            double min = 999999;
            double total = 0;
            int count = 0;
            StreamReader file = new StreamReader("temp.txt");
            while (!file.EndOfStream)
            {
                double num = Convert.ToDouble(file.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                total += num;
                count += 1;
            }
            file.Close();
            double average = total / count;
            Console.WriteLine("The maximum temperature is {0}", max);
            Console.WriteLine("The minimum temperature is {0}", min);
            Console.WriteLine("The average temperature is {0}", average);
        }
    }
}
