//You are given an array of strings. 
//Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).


using System;
using System.Collections.Generic;

class Task05ArrStrByLength
{
    static void Main(string[] args)
    {
        string[] words = { "astika", "mastika", "blablabau", "liolio_Kolio", "huawei", "suckers", "tintiri_mintiri", "mqu", };
        //ver. 1.0
        Array.Sort(words, (x, y) => (x.Length).CompareTo(y.Length));
        Console.WriteLine("And the sorted array : {0} ! ", string.Join(",", words));
        //ver 1.0 ends here

       // //ver 2.0 
       // int[] strLength = new int[words.Length];
       // for (int i = 0; i < words.Length; i++)
       // {
       //     strLength[i] = words[i].Length;
       // }


       // for (int i = 0; i < words.Length; i++)
       // {

       //     int minimal = int.MaxValue;
       //     int index = -1;
       //     string tempWord = words[i];

       //     for (int j = i; j < words.Length; j++)
       //     {
       //         if (strLength[j] < minimal)
       //         {
       //             minimal = strLength[j];
       //             index = j;
       //         }
       //         words[i] = words[index];
       //         words[index] = tempWord;
       //     }
       // }

       // foreach (string word in words)
       // {
       //     Console.WriteLine(word);
       // }
       //// ver. 2.0 ends here
    }
}

