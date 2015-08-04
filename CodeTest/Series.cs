using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class Series
    {

        public static List<double> SeriesToOrder { get; set; }
        public static double Number1 { get; set; }
        public static double Number2 { get; set; }

        public static double GetFirstNumber(double x)
        {
            return (0.5 * Math.Pow(x, 2) + (30 * x) + 10) / 25;
        }


        public static double GetGrowthRate(double y, double firstNumber)
        {
            var growthRate = 0.02 * y / (firstNumber * 25);

            return growthRate;
        }


        public static string CompleteSeries(double firstNumber, double growthRate, int length)
        {
            SeriesToOrder = new List<double>();
           
            var thisSeries = firstNumber;
            
            for (int i = 0; i < length; i++)
            {
                if (i > 0)
                {
                    thisSeries = growthRate * (Math.Pow(firstNumber, i));         
                }

                SeriesToOrder.Add(RoundToNearest(thisSeries, 0.25));           
            }
            
            return BuildCompleteSeries();      
        }

        private static double RoundToNearest(double numberToRound, double nearest)
        {
            return Math.Round(numberToRound /nearest, 0) * nearest;
        }

        private static string BuildCompleteSeries()
        {
            var theCompleteSeries = string.Empty;

            SeriesToOrder = SeriesToOrder.Distinct().ToList();

            SeriesToOrder.Sort();

            foreach (double s in SeriesToOrder)
            {
                theCompleteSeries += s + "<br>";
            }

            return theCompleteSeries;
        }


        public static string SpecialNumbers(double y, double z )
        {
            Number1 = SeriesToOrder[2];

            var approxNumber = y / z;
            Number2 = ApproximateNumber(approxNumber);

            return "Special Number1: " + Number1 + "<br>Approximate Number: " + approxNumber + "<br>Special Number2: " + Number2;

        }

        public static double ApproximateNumber(double approxNumber)
        {           
            var diff = 0.0;
            var smallestDiff = 100000.0;
            var specialNumber = 0.0;

            foreach (var item in SeriesToOrder)
            {
                diff = Math.Abs(item - approxNumber);
                if (diff < smallestDiff)
                {
                    smallestDiff = diff;
                    specialNumber = item;
                }
            }

            return specialNumber;
        }


      
    }
}
