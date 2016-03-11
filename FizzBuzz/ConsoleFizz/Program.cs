using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace ConsoleFizz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.FizzBuzz Fizz = new FizzBuzz.FizzBuzz();
            for (int i=1; i<=100; i++)
            {
                string result = Fizz.DoIt(i);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
