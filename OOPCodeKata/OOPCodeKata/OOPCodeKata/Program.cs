using System;

namespace OOPCodeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Animal : IMultiLimb
        {
            public string Name { get; set; }
            public int NumberOfLimbs { get; set; }
        }

        public class Alien : IMultiLimb
        {
            public string Name { get; set; }
            public int NumberOfLimbs { get; set; }
        }

        public class AnimalList<T> where T : IMultiLimb
        {

        }
    }
}
