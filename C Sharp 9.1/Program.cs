using System;
using System.IO;

namespace C_Sharp_9._1
{
    class Program
    {
        static void CreateFile()
        {
            bool valid = true;
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            StreamWriter file = new StreamWriter(fileName + ".txt");
            Console.WriteLine("Enter lines of text to go in file: (Enter an empty line to stop)");
            while (valid)
            {
                string text = Console.ReadLine();
                if (text == "")
                {
                    valid = false;
                }
                else
                {
                    file.WriteLine(text);
                }
            }
            Console.WriteLine("File Saved");
            file.Close();
            Menu();
        }
        
        static void ReadFile()
        {
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            StreamReader file = new StreamReader(fileName + ".txt");
            if (File.Exists(fileName + ".txt"))
            {
                while (!file.EndOfStream)
                {
                    Console.WriteLine(file.ReadLine());
                }
            }
            file.Close();
            Menu();
        }
        
        static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create text file");
            Console.WriteLine("2. Read text file");
            Console.WriteLine("3. Exit program");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateFile();
                    break;
                case 2:
                    ReadFile();
                    break;
                case 3:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
