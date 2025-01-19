using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleReasoning
{
    public static class StringExtension
    {
        public static string Reverse(this string str)
        {
            string reverse = "";
            for(int i=str.Length-1; i >= 0; i--)
            {
                reverse += str[i];
            }
            return reverse;
        }
        public static bool CheckAnagram(this string str, string str2)
        {
            StringComparison comparison = StringComparison.OrdinalIgnoreCase;
            char[] chars = str.ToUpper().ToCharArray();
            return chars.All(x => str2.ToUpper().Contains(x));
        }

        public static bool CheckAnagram2(this string str, string str2)
        {
            foreach(char c in str.ToUpper())
            {
               bool isExist= str2.ToUpper().Contains(c);
                if(!isExist) return false;
            }
            return true;
        }

        public static string FirstNonRepeatedCharacter(this string str) 
        {
            char[] chars = str.ToLower().ToCharArray();
            Dictionary<char, int> diclist = new Dictionary<char, int>();  

            for(int i = 0; i < chars.Length - 1; i++)
            {
                if (!diclist.ContainsKey(chars[i]))
                {
                    diclist[chars[i]] = 1;
                    //diclist.Add(chars[i], 1);
                }
                else
                    diclist[chars[i]]++;
                //diclist[chars[i]] =5;

            }

            foreach (var c in str)
            {
                if (diclist[c]==1)
                    return c.ToString();
            }
            return null;
        }

        public static string ReverseEachWord(this string str)
        {
            //string input = "This is a sample string to split by spaces.";
            string output = string.Empty;
            string[] splitedvalue = str.Split(' ');
            foreach(var word in splitedvalue)
            {
               for(int i = word.Length-1; i >=0;i--)
                {
                    output += word[i];
                }
                output += " ";
            }
            return output;
        }

        public static string PrintStringInTitleCase(this string str)
        {
            string[] splited= str.Split(' ');
            string titleCase = string.Empty;

            for(int i=0; i< splited.Length; i++)
            {
                //titleCase += splited[i].Substring(0, 1).ToUpper() + splited[i].Substring(1, splited[i].Length - 1) + " ";
            }

            foreach (var word in splited)
            {
                titleCase += word.Replace(word[0].ToString(), word[0].ToString().ToUpper())  + " ";
            }
            return titleCase;
        }

        public static string LongestWordInSentence(this string str)
        {

            string[] splitted = str.Split(' ');

            return splitted.OrderByDescending(x => x.Length).FirstOrDefault();

        }

        public static string AccountNumberMask(this string str)
        {
            string input = "12345678987";
            string output = string.Empty;
           
            for(int i=0;i< str.Length; i++)
            {
                if(i > 1  && i < str.Length-2  )
                    output += "*";
                else
                    output += str[i];
            }
            
            return output;
        }

        public static string PrintCreditCardFormat(this string str)
        {
            string input = "1111222233334444";
            string output = string.Empty;
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (k < 4)
                {
                    k++;
                    output += str[i];   //0,1,2,4, 5
                }
                else if (k == 4) {
                    k = 1;
                    output += "-"+str[i];
                }
                
            }

            return output;
        }

        public static string RemoveSpecialCharactor(this string str) {
            char[] chars = str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c<= 'z')) {
                sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string MoveSpecialCharactorAttheEnd(this string str)
        {
            char[] chars = str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();

            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    sb.Append(c);
                }
                else { 
                sb1.Append(c);
                }
            }
            return sb.Append(sb1).ToString();
        }
    }
}
