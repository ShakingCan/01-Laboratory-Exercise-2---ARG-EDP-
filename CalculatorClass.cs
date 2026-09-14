using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        
        public Formula<double> CalculateBS;
        public event Formula<double> CalculateEvent
        {
            add {

                Console.WriteLine("Added the Delegate");
                CalculateEvent += value;
            }
            remove
            {

                Console.WriteLine("Removed the Delegate");
                CalculateEvent -= value;
            }


        }

    public double getProduct(double arg1, double arg2)
        {
            return arg1 * arg2;

        }
        public double getQuotient(double arg1, double arg2)
        {
            return arg1 / arg2;

        }
        public double getSum(double arg1, double arg2)
        {
            return arg1 + arg2;

        }
        public double getDifference(double arg1, double arg2)
        {
            return arg1 - arg2;

        }
        public double Calculate(double arg1, double arg2)
        {
            return CalculateBS?.Invoke(arg1, arg2) ?? 0.0;
        }

    }
}
