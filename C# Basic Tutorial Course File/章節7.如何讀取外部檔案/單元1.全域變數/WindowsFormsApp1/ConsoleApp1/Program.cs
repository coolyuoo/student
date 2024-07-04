using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 30; i++)
            {
                string x = "*";

                for (int j = 0; j < i; j++)
                {
                    x += "*";
                }
                
                Console.WriteLine(x);
            }


            Console.ReadLine();


        }
    }
}
