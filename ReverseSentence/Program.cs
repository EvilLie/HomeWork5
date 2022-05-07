using System;

namespace HomeWork5
{
    internal class Program
    {
        public static void Output(string text)
        {
            Console.WriteLine(text);
        }
        public static string[] Split(string userStr)
        {
            string[] splittedStr = userStr.Split(' ');
            return splittedStr;
        }
        public static void PrintReverse(string[] splittedStr)
        {
            Array.Reverse(splittedStr);
            foreach (string str in splittedStr)
            {
                
                Output($"{str}");
            }
        }
        static void Main(string[] args)
        {
            Output("Please enter your sentence: ");
            string userStr = Console.ReadLine();
            string[] splittedStr = Split(userStr);
            PrintReverse(splittedStr);
        }
    }
}
