using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace CodeKataMethods
{
    public class Method
    {
        public static void Main()
        {
            //Console.WriteLine("The quick brown fox jumps over the lazy dog");
            #region AddArrayOfNumsThatAreDivisibleBy2Or3
            //int[] nums = new int[] { 21, 45, 26, 54, 11, 76, 44, 88, 23 };
            //Console.WriteLine(ArrayOfNums(nums));
            #endregion

            #region ReturnString
            //int[] array = new int[] { 1, 2, 3, 4 };
            //Console.WriteLine(ReturnString(array));
            #endregion

            #region CharacterIdentifier
            //while (true)
            //{
            //Console.WriteLine($"Character Identifier\nPlease enter a character");
            //var input = Console.ReadLine();
            //var type = CharacterIdentifier(input);
            //Console.WriteLine($"Entered character {input} is a {type}");
            //Console.WriteLine("Do you want to exit? (# for yes)");
            //var exit = Console.ReadLine();
            //if (exit == "#")
            //{
            //    Console.WriteLine("Goodbye");
            //    break;
            //}
            //}
            #endregion

            #region AverageMarks
            //Console.WriteLine("AverageMarks");
            //var inputMarks = Console.ReadLine();
            //Console.WriteLine($"Average marks of ({inputMarks}) = {AverageMarks(inputMarks)}");
            #endregion

            #region ConvertTemp
            //Console.WriteLine("Would you like to convert to Fahrenheit or Celsius?");
            //string conversion = Console.ReadLine();
            //Console.WriteLine("Please enter the temperature for conversion.");
            //string temp = Console.ReadLine();
            //var newTemp = ConvertTemperature(conversion, float.Parse(temp));
            //Console.WriteLine($"Your new temperature is: {newTemp}");
            #endregion

            #region Recursion
            //Console.Write("Enter a string: ");
            //var inputString = Console.ReadLine(); //read input from user

            //var reverseString = ReverseStringRecursion(inputString); // invoke the static method
            //Console.WriteLine($"Reverse of a String: {reverseString}"); // print the result
            #endregion

            #region DifferenceBetweenTwoElementsInAnArray
            //int[] numArray = { 2, 3, 1, 7, 9, 5, 11, 3, 5 };
            //Console.WriteLine($"Original array: {String.Join(", ", numArray)}");

            //Console.WriteLine($"The maximum difference between two elements of the given array is : " +
            //    $"{DiffBetweenTwoElements(numArray)}");
            #endregion

            #region SecondHighest
            //int[] numArray = new int[] { 2, 8, 1, 4, 2, 6, 7, 3, 4, 9 };
            //Console.WriteLine(SecondHighest(numArray));
            #endregion

            #region NearestToZero
            //int[] input = new int[] { 2, 8, 1, 4, 2, 6, 7, 3, 4, 9 };
            //Console.WriteLine(NumberClosestToZero(input));
            #endregion
        }

        #region TakeStringAndReturnArrayOfDuplicateCharacters
        //Create a method which takes a string and returns an array of duplicate characters.
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
        #endregion

        #region ReturnSumOfFibonacciNumbers
        //Create a method which returns the sum of fibonacci numbers up to the nth fibonacci number.
        public static int FibonacciNumbers(int input)
        {
            //List<int> fSequence = new List<int>() { 0, 1 };
            int firstNumber = 0; 
            int secondNumber = 1; 
            int sum = 0; 

            if (input <= 0 || input > 44)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i <= input; i++)
                {
                    sum = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = sum;
                }
                return sum - 1;
            }
        }
        #endregion

        #region ReverseAStringUsingRecursion
        //Create a program to reverse a String using recursion. 
        public static string ReverseStringRecursion(string input)
        {
            if (input.Length <= 1)
                return input;
            else
            {
                return ReverseStringRecursion(input.Substring(1)) + input[0];
            }
        }

        public static string ReverseString(string input)
        {
            List<char> inputList = input.ToList();
            StringBuilder outputString = new StringBuilder();

            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                outputString.Append(inputList[i]);
            }
            return outputString.ToString();
        }

        public static char[] ReverseStringStack(string input)
        {
            char[] outputArray = new char[input.Length];
            var stack = new Stack<char>();

            foreach (var x in input)
            {
                stack.Push(x);
            }
            for (int i = 0; i < outputArray.Length; i++)
            {
                outputArray[i] = stack.Pop();
            }
            return outputArray;
        }
        #endregion

        #region DifferenceBetweenTwoElementsInAnArray
        //takes an Int Array and returns the MAX-imum difference between the contents of the array
        public static int DiffBetweenTwoElements(int[] nums)
        {
            // Gareth efficient way
            //Array.Sort<int>(nums);
            //int diff = nums[nums.Length - 1] - nums[0];

            int max = int.MinValue;
            int min = int.MaxValue;

            if (nums == null || nums.Length < 2)
            {
                throw new ArgumentException();
            }
            else
            {
                foreach (var x in nums)
                {
                    if (x > max)
                    {
                        max = x;
                    }
                    if (x < min)
                    {
                        min = x;
                    }
                }
                return max - min;
            }
        }
        #endregion

        #region ConvertTemperature
        public static float ConvertTemperature(string conversion, float temp)
        {
            string unit = conversion.ToLower();
            float result = 0;

            if (unit == "fahrenheit")
            {
                result = ((temp - 32f) * (5f / 9f));
            }
            else if (unit == "celsius")
            {
                result = ((temp * (9f / 5f) + 32f));
            }
            return result;
        }
        #endregion

        #region AverageMarks
        //Create a program that will behave as follows from the command line:
        //c:/>AverageMarks 2 100 50
        //c:/>Average marks of(2,100,50) = 50.666666666666664
        public static float AverageMarks(string inputMarks)
        {
            if (inputMarks == null)
            {
                throw new ArgumentException();
            }

            string[] marks = inputMarks.Split(" ");
            float sum = 0;
             
            foreach (string s in marks)
            {
                if (float.Parse(s) < 0)
                {
                    throw new ArgumentException();
                }
                sum += float.Parse(s);
            }
            return sum / marks.Length;
        }

        #endregion

        #region CharacterIdentifier
        //Create a program that will behave as follows from the command line:

        //c:/>CharIdentifier
        //c:/>a
        //c:/>Entered character a is  Vowel
        //c:/>L
        //c:/>Entered character L is  Consonant
        //c:/>#
        //c:/>Goodbye

        public static string CharacterIdentifier(string input)
        {
            List<char> vowel = new List<char>() { 'A', 'E', 'I', 'O', 'U' };
            List<char> consonant = new List<char>() { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V','W','X','Y','Z' };

            string letter = input.ToUpper();
            string output = "";

            for (int i = 0; i < vowel.Count(); i++)
            {
                if (vowel[i].ToString() == letter)
                {
                    output = "vowel";
                }
            }
            for (int i = 0; i < consonant.Count(); i++)
            {
                if (consonant[i].ToString() == letter)
                {
                    output = "consonant";
                }
            }
            if (output == "")
            {
                output = "Invalid character";
            }
            return output;

            /*
             * if (vowel.Contains(letter)) return "Vowel";
             * else if (consonant.Contains(letter)) return "Consonant";
             * return null;
             */
        }
        #endregion

        #region SecondHighestNumberInArray
        public static int SecondHighest(int[] numArray)
        {
            Array.Sort(numArray);
            return numArray[numArray.Length - 1];
        }
        #endregion

        #region StringWithVowelsRemoved
        //return a string with the vowels removed to upper
        public static string NoVowels(string input)
        {
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            string output = "";
            string uInput = input.ToUpper();
            char[] inputArray = uInput.ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!vowels.Contains(inputArray[i]))
                {
                   output += inputArray[i];
                }
            }
            return output;
        }
        #endregion

        #region ReturnStringFromArray
        // Return a string from an array
        public static string ReturnString (int[] input)
        {
            string output = string.Empty;
            foreach (var num in input)
            {
                output += num;
            }
            return output;
        }
        #endregion

        #region AddArrayOfNumsThatAreDivisibleBy2Or3
        public static int ArrayOfNums(int[] nums) 
        {
            int result = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0 || nums[i] % 3 == 0)
            //    {
            //        result += i;
            //    }
            //}
            //return result;

            foreach(var num in nums)
            {
                if (num % 2 == 0 || num % 3 == 0)
                {
                    result += num;
                }
            }
            return result;
        }
        #endregion

        #region AnimalYears
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {

            int catYears = 24;
            int dogYears = 24;

            if (humanYears < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = 0; i <= humanYears; i++)
                {
                    if (humanYears == 1)
                    {
                        catYears = 15;
                        dogYears = 15;
                    }
                    else if (humanYears == 2)
                    {
                        catYears = 24;
                        dogYears = 24;
                    }
                    else
                    {
                        for (i = 3; i <= humanYears; i++)
                        {
                            catYears += 4;
                            dogYears += 5;
                        }
                    }
                }
            }
            return new int[] { humanYears, catYears, dogYears };
        }
        #endregion

        #region ReturnNumberClosestTo0
        //Create a method that takes an int[] array and returns the number which is closest to 0
        public static int NumberClosestToZero(int[] input)
        {
            
            var result = input.Max();

            if (input == null || input.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < result)
                    {
                        result = input[i];
                    }
                }
            }
            return result;
        }

        public static int NumberClosestToZero2(int[] input)
        {
            int current = 0;
            int result = input[0];
            Array.Sort(input);

            if (input == null || input.Length == 0)
            {
                throw new ArgumentNullException();
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    current = input[i] * input[i];
                    if (current <= (result * result))
                    {
                        result = input[i];
                    }
                }
            } 
            return result;
        }
        #endregion

        #region GroupedByCommas
        public static string GroupedByCommas(int n)
        {
            return n.ToString("N0");
        }
        #endregion

        #region WhoLikesIt?
        public static string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }
            else if (name.Length == 1)
            {
                return $"{name[0]} likes this";
            }
            else if (name.Length == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }

        public static string LikesOL(string[] name)
        {
            return name.Length < 2 ? (name.Length == 1 ? name[0] : "no one") + " likes this" : string.Format("{0}{1} and {2} like this",
                    name.Length == 2 ? new string[] { "", name[0], name[1] } : new string[] { name[0] + ", ",
                    name[1], name.Length > 3 ? (name.Length - 2).ToString() + " others" : name[2] });
        }
        #endregion

        #region Fibonacci Number
        // Write a method/s which determines whether a number is a Fibonacci number.
        public static bool IsThisAFibonacciNumber(int input)
        {
            // A number is Fibonacci if and only if one or both of (5n2 + 4) or (5n2 – 4) is a perfect square (Source: Wiki).
            // Following is a simple program based on this concept.

            List<int> numList = new List<int>() { 0, 1 };
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 0; i < input; i++)
            {
                c = a + b;
                numList.Add(c);
                a = b;
                numList.Add(a);
                b = c;
                numList.Add(b);
            }
            foreach (var num in numList)
            {
                if (input == num)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsThisAFibonacciNumberOL(int input)
        {
            return Math.Sqrt(5 * Math.Pow(input, 2) + 4) % (int)Math.Sqrt(5 * Math.Pow(input, 2) + 4) == 0 ||
                Math.Sqrt(5 * Math.Pow(input, 2) - 4) % (int)Math.Sqrt(5 * Math.Pow(input, 2) - 4) == 0;
        }
        #endregion
    }
}
