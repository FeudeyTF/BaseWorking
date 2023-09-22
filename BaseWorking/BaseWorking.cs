using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWorking
{
    internal class BaseWorking
    {
        public static string Alphabet = "0123456789abcdefghijklmnopqrstuvwxyz";
        public static string ToBase(long number, int bas)
        {
            string result = "";
            while (number != 0)
            {
                result = Alphabet[(int)(number % bas)] + result;
                number /= bas;
            }
            return result;
        }
        public static long FromBase(string number, int bas)
        {
            long result = 0;
            for(int i = number.Length; i > 0; i--)
                result += (long)(Alphabet.IndexOf(number[i - 1].ToString().ToLower()) * Math.Pow(bas, number.Length - i));
            return result;
        }

        public static string FromToBase(string number, int prevBase, int nextBase) => ToBase(FromBase(number, prevBase), nextBase);
    }
}
