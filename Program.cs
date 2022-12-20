using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z = 0;
            Console.WriteLine("enter first number");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            for(x = num1; x <= num2;x++)
            {
                for (y = 2; y <= sqrt(x); y++)
                {
                    if (x%y==0) 
                    {
                        z = 0;
                    }
                }
                if(z==1&&x!=1)
                {
                    Console.WriteLine(x + "is prime");
                }
                z = 1;
                
            }


            Console.ReadKey();
        }
        static double sqrt (int x) 
        {
            return Math.Sqrt(x);    
        }
    }
}
