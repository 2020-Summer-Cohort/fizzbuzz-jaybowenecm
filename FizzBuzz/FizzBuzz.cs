using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
   public class FizzBuzz
    {

        public string Get(int num)
        {
            if (IsMultipleOf3(num))
                return "Fizz";

            else if (IsMultipleOf5(num))
               return "Fizz";

            else
                return num.ToString();
        }

        private static bool IsMultipleOf3(int num)
        {
            return (num % 3 == 0);
                
        }

        private static bool IsMultipleOf5(int num)
        {
            return (num % 5 == 0);

        }
    }
}
