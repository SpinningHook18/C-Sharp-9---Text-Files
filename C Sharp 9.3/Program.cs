using System;
using System.IO;

namespace C_Sharp_9._3
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }

        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("Message.txt");
            int key = Convert.ToInt32(file.ReadLine());
            Console.WriteLine(Convert.ToString(key));
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    char ch = line[i];
                    Console.Write(cipher(ch, key));
                }
                Console.WriteLine();
            }
            file.Close();
        }
    }
}
