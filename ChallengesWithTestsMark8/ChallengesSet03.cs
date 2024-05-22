using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
                return false;

            foreach (var tOrF in vals)
            {
                if (tOrF == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            
            if (sum % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password == null)
                return false;

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char character in password)
            {
   
                if (char.IsUpper(character))
                {
                    hasUpper = true;
                }
                if (char.IsLower(character))
                {
                    hasLower = true;
                }
                if (char.IsDigit(character))
                {
                    hasDigit = true;
                }
            }
            if (hasUpper is true && hasLower is true && hasDigit is true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            var firstChar = val.First();
            return firstChar;
        }

        public char GetLastLetterOfString(string val)
        {
            var lastChar = val.Last();
            return lastChar;
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
            var firstNum = nums.First();
            var lastNum = nums.Last();

            return lastNum - firstNum;
        }

        public int[] GetOddsBelow100()
        {
            int[] oneHundred = Enumerable.Range(1, 100).ToArray();
            var oddsOnly = new List<int>(); 

            foreach (int number in oneHundred)
            {
                if (number % 2 != 0)
                {
                    oddsOnly.Add(number);
                }
            }
            return oddsOnly.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            var upperList = new List<string>();

            foreach (string word in words)
            {
                var upperString = word.ToUpper();
                upperList.Add(upperString);
            }
            for (int i = 0; i < upperList.Count; i++)
            {
                words[i] = upperList[i];
            }
        }
    }
}
