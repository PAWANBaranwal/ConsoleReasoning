using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReasoning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "Pawan";
            //string str2 = "PwaaN";
            //string val1 = "Listen";
            //string val2 = "Silent";
            Console.WriteLine(StringExtension.Reverse("PAWAN"));
          

            Console.WriteLine($" Pawan is :-{StringExtension.CheckAnagram("Listen","Silent")}");
            Console.WriteLine($"Listen is :-{StringExtension.CheckAnagram2("Listen", "Silent")}");
            Console.WriteLine($"First not repeat char is : {StringExtension.FirstNonRepeatedCharacter("entertainment")}");

            Console.WriteLine($"Reverse each word  is : {StringExtension.ReverseEachWord("Pawan Kumar Baranwal")}");
            Console.WriteLine($"Print String In Title Case  is : {StringExtension.PrintStringInTitleCase("pawan kumar baranwal")}");
            Console.WriteLine($"Longest Word In Sentence  is : {StringExtension.LongestWordInSentence("pawan kumar baranwal")}");

            Console.WriteLine($"Account Number Mask  is : {StringExtension.AccountNumberMask("12345678987")}");

            Console.WriteLine($"Print Credit Card Format  is : {StringExtension.PrintCreditCardFormat("1111222233334444")}");
            Console.WriteLine($"Remove Special Charactor  is : {StringExtension.RemoveSpecialCharactor("Hello$*hgjhgjhhj&!@#$%")}");
            Console.WriteLine($"Move all the Special Charactor at the end is : {StringExtension.MoveSpecialCharactorAttheEnd("Hello$*hgjhgjhhj&!@#$%")}");


            //var a = string.Empty;
            //a = "";
            int? a = 20;
            int b = 11;
            if (a is null) { }
            b = (int) a ;




            Console.ReadLine();

        }
    }
}
