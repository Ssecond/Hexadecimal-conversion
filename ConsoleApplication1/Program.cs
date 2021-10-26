using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string h = "ABCDEF";
            string d = string.Empty;
            string s = string.Empty;
            int x = 0;
            Console.WriteLine("Введите число которое нужно перевести");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите систему исчисления");
            s = Console.ReadLine();
            int y = 0;
            
            if (s == "16")
            {
                while (x > 0)
                {
                    y = x % 16;
                    x = x / 16;
                    if (y < 10)
                    {
                        d = y.ToString() + d;
                    }
                    else
                    {
                        d = h[y - 10] + d;
                    }
                }
            }
            
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
