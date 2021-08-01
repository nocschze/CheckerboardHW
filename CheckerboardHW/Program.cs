using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerboardHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string yildiz = "* ";
            char bosluk = ' ';
            int dizin = 1;
            int kose = 1;

            while (dizin <= 4)
            {
                if (dizin % 2 != 0)
                {
                    while (kose <= 4)
                    {
                        Console.Write(yildiz);
                        kose++;
                    }
                }
                else
                {
                    Console.Write(bosluk);
                    while (kose <= 4)
                    {
                        Console.Write(yildiz);
                        kose++;
                    }
                }
                kose = 1;
                dizin++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
