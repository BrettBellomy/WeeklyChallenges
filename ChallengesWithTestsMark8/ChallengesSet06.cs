using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();

                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;

            if (num >= 0)
            {
                if (num % 2 != 0 || num % 3 != 0)
                {
                    isPrime = true;
                }

                if (num % 2 == 0 || num % 3 == 0)
                {
                    isPrime = false;
                }

                if (num == 1)
                {
                    isPrime = false;
                }

                if (num == 2 || num == 3)
                {
                    isPrime = true;
                }
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            // full transparency here-- I got pretty stuck on this one and had to reference Mack's work on this one from his GitHub for help. Thanks Mack! :)
            if (str.Length == 1)
            {
                return 0;
            }
            
            if (str.All(x => x == str[0]))
            {
                return -1;
            }

            char unique = str.Last(x => str.Count(c => c == x) == 1);

            return str.LastIndexOf(unique);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();
        }
    }
}