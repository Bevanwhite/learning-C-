using System;

namespace Complex
{
    class Program
    {
        public struct Complex
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }

            // Overload the + operator
            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex
                {
                    Real = c1.Real + c2.Real,
                    Imaginary = c1.Imaginary + c2.Imaginary
                };
            }

        }

        static void Main(string[] args)
        {
            var a = new Complex{ Real = 1, Imaginary = 2};
            var b = new Complex{ Real = 4, Imaginary = 8};
            var c = a + b;

            Console.WriteLine($"c.Real = {c.Real}, c.Imaginary = {c.Imaginary}");
        }
    }
}
