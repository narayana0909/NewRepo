using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Num:");
            int iFirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(("Enter second num:"));
            int iSecondNum = Convert.ToInt32(Console.ReadLine());


            int isum = iFirstNum + iSecondNum;

            Console.WriteLine(isum);



        }
    }
}
