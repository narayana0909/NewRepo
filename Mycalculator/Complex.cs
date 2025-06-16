﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mycalculator
{
    public class Complex
    {
        private int _Operand1 = 0;
        private int _Operand2 = 0;

        public int Operand1
        {
            get
            {
                return _Operand1;
            }
            set
            {
                _Operand1 = value;
            }
        }
        public int Operand2
        {
            get
            {
                return _Operand2;
            }
            set
            {
                _Operand2 = value;
            }
        }
        public static int Add(int Operand1,int Operand2)
        {
            return Operand1 + Operand2;
        }
        public static int Subtract(int Operand1,int Operand2)
        {
            return Operand1 - Operand2;
        }
        public static int Multiply(int Operand1, int Operand2)
        {
            return (Operand1 * Operand2);
        }
        public static int? Divide(int Operand1, int Operand2)
        {
            if (Operand2 == 0)
            {
                return null;
            }
            return Operand1 / Operand2;
        }
        public static int Power(int Operand1, int Operand2)
        {
            if (Operand2 < 0)
            {
                Console.WriteLine("Exponents must be non-negative");
            }
                int result = 1;
                for (int i = 0; i < Operand2; i++)
                {
                    result *= Operand1;
                }
                return result;
            
        }
        public static int Root(int Operand1, int Operand2)
        {
            if (Operand2<=0)
            {
                Console.WriteLine("Root must be positive");
                
            }
            return (int)Math.Sqrt(Operand1);

        }

    }

}
