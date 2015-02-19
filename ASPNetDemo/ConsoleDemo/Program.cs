using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] arr = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight" };

           //for (int i=0; i<arr.Length; i++)
           //{
           //    if (arr[i].Length < i)
           //    {
           //        Console.WriteLine("The word " + arr[i] + " is shorter than its value.");
           //    }
           // }


           //var digits = arr.AsEnumerable();
           //var shortDigits = digits.Where((digit, index) => digit.Length < index);
           //Console.WriteLine("Short digits:");
           //foreach (var d in shortDigits)
           //{
           //    Console.WriteLine("The word " + d + " is shorter than its value.");
           //}

            
            ///

            //int[] arr = new int[] { 4,5,6,7,8,9};
            //var numbers = arr.AsEnumerable();
            //var numsPlusOne =
            //    from n in numbers
            //    select n + 1;

            //Console.WriteLine("Numbers + 1:");
            //foreach (var i in numsPlusOne)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] testDS = { 9,7,1,8,6,4,5,0,3,2 };            
            //string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var numbers = testDS.AsEnumerable();
            //var textNums = numbers.Select(p => strings[p]);
            //Console.WriteLine("Number strings:");
            //foreach (var s in textNums)
            //{
            //    Console.WriteLine(s);
            //}          

            //string[] words = {"apple","banana","potato"};
            //var upperLowerWords = words.Select(p => new
            //{
            //    Upper = (p).ToUpper(),
            //    Lower = (p).ToLower()
            //});
            //foreach (var ul in upperLowerWords)
            //{
            //    Console.WriteLine("Uppercase: " + ul.Upper + ", Lowercase: " + ul.Lower);
            //}

            string[] words = new string[] { "zero", "three", "two", "one", "our", "five", "six", "seven", "eight" };
         //   var sortedWords =
         //from w in words
         //orderby w.Length
         //select w;
         //   Console.WriteLine("The sorted list of words (by length):");
         //   foreach (var w in sortedWords)
         //   {
         //       Console.WriteLine(w);
         //   }

            var digits = words.AsEnumerable();
            var startsWithO = digits.First(s => s.ToString()[0] == 'o');
            Console.WriteLine("A string starting with 'o': {0}", startsWithO);          



            Console.ReadLine();
        }
    }
}
