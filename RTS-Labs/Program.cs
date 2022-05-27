using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RTS_Labs
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 5, 2, 1, 10 };

            Console.WriteLine(AboveBelow(numbers, 6));
            Console.WriteLine(StringRotation("MyString", 2));
        }
        public static string AboveBelow(List<int> Numbers, int num)
        {
            List<int> compValue = new List<int> { 0, 0 };

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] > num) compValue[0]++;
                if (Numbers[i] < num) compValue[1]++;
            }
                return "Above: " + compValue[0] + " " + "Below: " + compValue[1]; 
        }
        public static string StringRotation(string rotate, int pos)
        {
            string firstLetters = "";
            string secondLetters = "";

            for (int i = 0; i < rotate.Length; i++)
            {
                if (i < rotate.Length - pos) firstLetters += rotate[i];
                else secondLetters += rotate[i];
            }
            return secondLetters + firstLetters;
        }
    }
}
