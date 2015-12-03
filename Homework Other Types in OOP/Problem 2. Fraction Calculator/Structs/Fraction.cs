using System;
using System.CodeDom;

namespace Problem_2.Fraction_Calculator.Structs
{
    public struct Fraction
    {
        public long Numerator { get; set; }
        private long denominator;

        public Fraction(long numerator, long denominator):this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("The denominator cannot be zero.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction firstFraction, Fraction secondFraction)
        {
            return new Fraction(((firstFraction.Numerator*secondFraction.Denominator) + (firstFraction.Denominator * secondFraction.Numerator)),(firstFraction.Denominator * secondFraction.Denominator));
        }

        public override string ToString()
        {
            return (Numerator/(decimal)Denominator).ToString();
        }
    }
}