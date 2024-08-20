using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    answer += num;
                }
                if (num % 2 != 0)
                {
                    answer -= num;
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string stringOne, string stringTwo, string stringThree, string stringFour)
        {
            int stringOneLength = stringOne.Length;
            int stringTwoLength = stringTwo.Length;
            int stringThreeLength = stringThree.Length;
            int stringFourLength = stringFour.Length;

            int[] stringLengths = new int[] { stringOneLength, stringTwoLength, stringThreeLength, stringFourLength };

            return stringLengths.Min();
        }

        public int GetSmallestNumber(int numOne, int numTwo, int numThree, int numFour)
        {
            int[] numbers = new int[] { numOne, numTwo, numThree, numFour };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business myBusiness)
        {
            myBusiness.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideOneLength, int sideTwoLength, int sideThreeLength)
        {
            if (sideOneLength + sideTwoLength > sideThreeLength && sideOneLength + sideThreeLength > sideTwoLength && sideTwoLength + sideThreeLength > sideOneLength)
            {
                return true;
            }
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            double number;
            if (double.TryParse(input, out number))
            {
                return true;
            }
            else return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCounter = 0;
            int otherCounter = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    nullCounter++;
                }
                else
                {
                    otherCounter++;
                }
            }
            return nullCounter > otherCounter ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            List<double> numbersList = new List<double>();

            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            foreach (var num in numbers)
            {

                if (num % 2 == 0)
                {
                    numbersList.Add(num);
                }
            }

            if (!numbersList.Any())
            {
                return 0;
            }
            return numbersList.Average();
        }

        public int Factorial(int number)
        {
            int fact = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int x = number; x > 0; x--)
            {
                fact *= x;
            }

            return fact;
        }
    }
}