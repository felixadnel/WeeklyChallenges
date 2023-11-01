﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }

            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int len3 = str3.Length;
            int len4 = str4.Length;

            int shortest = len1;  

            if (len2 < shortest) shortest = len2;
            if (len3 < shortest) shortest = len3;
            if (len4 < shortest) shortest = len4;

            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1; 

            if (number2 < smallest) smallest = number2;
            if (number3 < smallest) smallest = number3;
            if (number4 < smallest) smallest = number4;

            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
          sideLength1 + sideLength3 > sideLength2 &&
          sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }

            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int sum = 0;
            int count = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }

            if (count == 0) return 0; 

            return (double)sum / count;
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("Number must be a non-negative integer.");

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
