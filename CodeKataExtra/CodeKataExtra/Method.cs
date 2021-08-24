using System;
using System.Collections.Generic;
using System.Linq;


namespace CodeKataMethods
{
    public class Method
    {
        public static void Main()
        {
            //Create a method which takes a string and returns an array of duplicate characters
            //e.g. "Nishant Mandal" => (a,n)

            //Create a method which returns the sum of fibonacci numbers up to the nth fibonacci number.
        }

        public static char[] ReturnDuplicate(string input)
        {
            string inputLower = input.ToLower();

            char[] inputArray = inputLower.ToCharArray();

            string duplicateChar = "";

            string seenChar = "";

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (seenChar.Contains(inputArray[i].ToString()))
                {
                    if (!duplicateChar.Contains(inputArray[i].ToString()))
                    {
                        duplicateChar += inputArray[i].ToString();
                    }
                }
                else
                {
                    seenChar += inputArray[i].ToString();
                }
            }
            char[] resultArray = duplicateChar.ToCharArray();

            return resultArray;
        }

        public static int FibonacciNumbers(int input)
        {
            List<int> fSequence = new List<int>() { 0, 1 };
            
            if (input <= 0 || input > 44)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                while ((int)fSequence.Count <= input + 2)
                {
                    fSequence.Add(fSequence[fSequence.Count - 1] + fSequence[fSequence.Count - 2]);
                }
                return (fSequence[fSequence.Count - 1] - 1);
            }
        }
    }
}
