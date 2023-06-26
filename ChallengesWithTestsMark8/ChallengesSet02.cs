using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0.0;
            }

            double min = numbers.Min();
            double max = numbers.Max();

            double sum = min + max;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1?.Length ?? 0;
            int length2 = str2?.Length ?? 0;

            if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                
            }
               return sum;
        }
        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
                return sum;
            
        }
        public bool IsSumOdd(List<int> numbers)
        {
         if (numbers == null)
         {
           return false; 
         }

          int sum = 0;
         foreach (int number in numbers)
         {
           sum += number;
         }

          return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }

            long count = 0;
            for (long i = 1; i < number; i += 2)
            {
                count++;
            }

            return count;
        }

    }
       
}
