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

            char[] outputArray = inputLower.ToCharArray();

            string duplicateChar = "";

            string seenChar = "";

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (seenChar.Contains(outputArray[i].ToString()))
                {
                    if (!duplicateChar.Contains(outputArray[i].ToString()))
                    {
                        duplicateChar += outputArray[i].ToString();
                    }
                }
                else
                {
                    seenChar += outputArray[i].ToString();
                }
            }

            char[] resultArray = duplicateChar.ToCharArray();

            return resultArray;
        }
    }


}
