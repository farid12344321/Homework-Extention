using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_Extention
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int n)
        {
            if (n == 0) return false;
            if (n % 2 == 0) return false;

            return true;
        }
        public static bool IsEven(this int n)
        {
            if (n == 0) return false;
            if (n % 2 == 1) return false;

            return true;
        }
        public static bool IsContainsDigit(this string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string text)
        {
            var text2 = text.Trim().ToLower();
            string upperCase = "";
            for (int i = 0; i < text2.Length; i++)
                upperCase = text2[0].ToString().ToUpper() + text2.Substring(1);
            
            return upperCase;
        }
        public static void GetValueIndexes(this string text,char n)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == n)
                {
                    count++;
                }
            }
            int[] datas = new int[count];
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] == n)
                {
                    datas[index] = i;
                    index++;
                }
            }
            for (int i = 0; i < datas.Length; i++)
            {
                Console.WriteLine(datas[i]);
            }
            
        }
        public static string GetFirstSentence(this string text)
        {
            return text.Substring(0,text.IndexOf('.'));
        }
        public static string GetSecondWord(this string text)
        {
            return text.Substring(text.IndexOf(" ") +1,text.IndexOf(" "));
            
        }
    }
}
