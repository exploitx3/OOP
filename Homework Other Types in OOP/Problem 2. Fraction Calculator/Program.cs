using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem_2.Fraction_Calculator.Structs;

namespace Problem_2.Fraction_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);

        }
    }
}
