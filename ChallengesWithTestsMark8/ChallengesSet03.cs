using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (!val) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null) return false;

            int sumOfOdds = 0;

            foreach (int num in numbers)
            {
                if (num % 2 != 0) 
                {
                    sumOfOdds += num;
                }
            }

            return sumOfOdds % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z') hasUpper = true;
                if (c >= 'a' && c <= 'z') hasLower = true;
                if (c >= '0' && c <= '9') hasDigit = true;

                if (hasUpper && hasLower && hasDigit) return true;
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
                throw new ArgumentException("The provided string is null or empty.");

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0; 
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if(nums == null || nums.Length == 0)
        return 0; 

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i]?.ToUpper();
            }
        }
    }
}
