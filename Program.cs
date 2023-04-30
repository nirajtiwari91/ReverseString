using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ReverseString();
            obj.ReverseString1();
            Console.ReadLine();
        }

        public void ReverseString()
        {
            string strForReverse = "NIRAJ";
            char[] array = strForReverse.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine("ReverseString - Reversed String is {0}", new string(array));
        } 
        public void ReverseString1()
        {
            string strForReverse = "NIRAJ";
            string strReverse = "";
            int iLength = strForReverse.Length - 1;// find string length
            while (iLength >= 0)
            {
                strReverse = strReverse + strForReverse[iLength];
                iLength--;
            }
            Console.WriteLine("ReverseString1 - Reversed String is {0}", strReverse);
        }
    }
}
