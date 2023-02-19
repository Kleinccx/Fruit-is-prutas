using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myfile = @"fruit.txt";
            File.WriteAllText(myfile, "");


            using (StreamWriter write = File.AppendText(myfile))
          
            {

                for(int a = 0; a < 10; a++)
                {
                    Console.Write("Enter fruit: ");
                    write.WriteLine(Console.ReadLine());
                }
               


            }
            using (StreamReader sr = File.OpenText(myfile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Search a fruit: ");
                string input = Console.ReadLine();
                string[] lines = File.ReadAllLines(myfile);

                string found = "Not Found";
              


              
                foreach (string line in lines)
                {
                    if (line.Contains(input))
                    {
                        found = "Found";

                        break;
                    }
             


                }
                Console.WriteLine(found);
                if (input.Equals("exit"))
                {
                    Console.WriteLine("You chose to exit.   Goodbye!");
                }


            }
        }

    }
    }




