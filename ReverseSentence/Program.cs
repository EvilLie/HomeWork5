using System;

namespace HomeWork5
{
    internal class Program
    {
        public static void Output(string text)
        {
            Console.Write(text);
        }
        public static string[] Split(string userStr)
        {
            string[] splittedStr = userStr.Split(new[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries);
            return splittedStr;
        }
        public static void PrintReverse(string userStr)
        {         
            string[] splittedStr =  Split(userStr);
            Array.Reverse(splittedStr);
            Output(string.Join(", ", splittedStr));
        }
        static void Main(string[] args)
        {
            Output("Please enter your sentence: \n");
            string userStr = Console.ReadLine();
            PrintReverse(userStr);
            Output("\n");
        }
    }
}
