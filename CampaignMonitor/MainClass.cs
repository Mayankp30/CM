using System;
using System.Collections.Generic;
using System.Linq;

namespace CampaignMonitor
{
    // Requirement 1 - Null or Empty
    public static class MyStringExtensions{
        public static bool IsNullOrEmpty(this string value){
            return (value == null || value == string.Empty);
        }
    }

   public class MainClass{
        //Requirement 2 - Get Divisors of a number
        public static List<int> getDivisors(int number){
            List<int> list = new List<int>();
            if (number < 1){
                Console.WriteLine("Invalid Input");
            }
            for (int i = 1; i <= number; i++){
                if (number % i == 0){
                    list.Add(i);
                }
            }
            return list;
        }

        // Requirement 3 - calculate area of a traingle 
        public static double calculateTArea(int a, int b, int c) {
            if ((a < 0) || (b < 0) || (c < 0)){
                throw new InvalidTriangleException("Triangles sides cannot be negative");
            }
            double area = double.NaN;
            try
            {
                if ((a + b) > c && (a + c) > b && (b + c) > a)
                {
                    int halfP = (a + b + c) / 2;   // half of the perimeter of triangle
                    area = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
                }
                else
                {
                    throw new InvalidTriangleException("The input parameters do not make a triangle");
                }
            }
            catch (Exception exe)
            {

                Console.WriteLine(exe.Message);
                throw exe;   
            }

            return area;

        }


        // Requirement 4 - Get the most common elements from array
        public static int[] getMostCommonUsedNumber(int[] array) {
            var itemListByFreq = from numbers in array
                                 group numbers by numbers into grouped
                                 orderby grouped.Count() descending
                                 select new { Number = grouped.Key, Freq = grouped.Count() };

            // Select all values with max freq

            var listWithMaxFreq = from u in itemListByFreq
                                  where u.Freq == itemListByFreq.Max(y => y.Freq)
                                  select u.Number;

            return listWithMaxFreq.ToArray();
        }

        public static void Main(string[] args){

        }
    }
}