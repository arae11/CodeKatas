using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKataMethods
{
    public class Method
    {
        //Create a method which takes a string and returns an array of duplicate characters
        //e.g. "Nishant Mandal" => (a,n)

        public static char[] ReturnDuplicate(string input)
        {
            input = input.ToLower();

            char[] outputArray = input.ToCharArray();

            string result = "";

            string duplicate = "";

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (duplicate.Contains(outputArray[i].ToString()))
                {
                    result += outputArray[i].ToString();
                }
                else
                {
                    duplicate += outputArray[i].ToString();
                }
            }

            char[] resultArray = result.ToCharArray();

            return resultArray;
        }
    }


}
