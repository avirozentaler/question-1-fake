using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
                if (i%2!=0&&i%3!=0&&i%5!=0&&i%7!=0||i==3||i==5||i==7)
                   
                {
                    Console.WriteLine(i);
                }
            {

            }
        }
    }
}
