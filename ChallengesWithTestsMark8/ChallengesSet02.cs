using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            var charArray = lowercaseAlphabet.ToCharArray();
            var lowerCase = char.ToLower(c);
            if (charArray.Contains(lowerCase))
            {     
                return true;
            }    
            else return false;
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                 return true; 
            }
            else  return false; 
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2  != 0)
            {
                return true;
            }
            else  return false;  
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var numbersArray = numbers.ToArray();
            Array.Sort(numbersArray);

            if (numbersArray.Length == 0)
            {
                return 0;
            }

            var numbersSorted = numbersArray.ToList();
            double firstNumber = numbersSorted.First();
            double lastNumber = numbersSorted.Last();
            int itemCount = numbers.Count();
            double sum = 0;
            
            if (itemCount == 1)
            {
                sum = firstNumber + firstNumber;
                return sum;
            }
            if (itemCount >= 1)
            {
                sum = firstNumber + lastNumber;
                return sum;
            }
            if (itemCount == 0)
            {
                return 0;
            }
            else 
            {
                return 0;
            }  
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            str1.ToCharArray();
            str2.ToCharArray();

            if (str1.Length < str2.Length) 
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
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
            else numbers = null;
                
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;

            if (numbers == null) return 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) 
                {
                    evenSum += numbers[i];
                }
            } 
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers != null)

                for (int i = 0; i < numbers.Count;  ++i)
                {
                   sum += numbers[i];
                }
                else return false;

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var numbersCount = new List<int>();
            int oddNumbers = 0;
            for (int i = 0; i < number; i++)
            {
                numbersCount.Add(i + 1);
                if (i % 2 != 0)
                {
                    oddNumbers++;
                }
            }
            return oddNumbers;
        }
    }
}
