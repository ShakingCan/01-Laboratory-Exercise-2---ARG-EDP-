using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public delegate T Information<T>(T arg1);
    internal class CalculatorClass
    {
        public Information<string> info;

        public double GetSum(double sum)
        {

            return sum;
        
        }

        public double GetDifference(double difference)
        {

            return difference;


        }

    }
}
