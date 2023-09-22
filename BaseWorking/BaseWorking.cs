using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    internal class BaseWorking
    {
        public static string Alphabet = "0123456789abcdefghijklmnopqrstuvwxyz";
        public static string ToBase(BigInteger number, int bas)
        {
            string result = "";
            while (number != 0)
            {
                result = Alphabet[(int)(number % bas)] + result;
                number /= bas;
            }
            return result;
        }
        public static BigInteger FromBase(string number, int bas)
        {
            BigInteger result = 0;
            for(int i = number.Length; i > 0; i--)
                result += (BigInteger)(Alphabet.IndexOf(number[i - 1].ToString().ToLower()) * Math.Pow(bas, number.Length - i));
            return result;
        }

        public static string FromToBase(string number, int prevBase, int nextBase) => ToBase(FromBase(number, prevBase), nextBase);

        public static BigInteger Power(int num, int j)
        {
            BigInteger result = num;
            for (int i = 1; i < j; i++)
                result *= num;
            return result;
        }
    }
}
