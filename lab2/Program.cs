using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\Data\Input.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (char.IsPunctuation(ch))
                        {
                            if ((ch == '.') || (ch == '?') || (ch == '!'))
                                Console.Write(ch + "\n");
                            else
                                Console.Write(ch);
                        }                      
                        else
                            Console.Write(ch);
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}


