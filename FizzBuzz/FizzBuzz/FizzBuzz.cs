using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz ()
        {

        }

        Dictionary<int, string> rules = new Dictionary<int, string>()
        {
            {15, "FizzBuzz" },
            {5, "Buzz" },
            {3, "Fizz" }
        };
        
        public string DoIt(int number)
        {
            foreach (var key in rules.Keys)
            {
                if (number % key == 0)
                    return rules[key];
            }

            return number.ToString();
        }

    }
}
