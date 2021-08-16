using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKataMethods
{
    public class Method
    {
        //Create a method which takes a string and returns an array of duplicate characters
        //e.g. "Nishant Mandal" => (a,n)
        public static void Main()
        {

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
    }


}
