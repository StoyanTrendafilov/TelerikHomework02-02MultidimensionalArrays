//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 


using System;

class Task04StrMatrixBinSearch
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter the length oy your array : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter wanted element : ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please, enter value for element number {0} of your array: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        
        //// ver. 1.0 - without binary search
        
        //int check = 0;
        //int checkIndex = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    if (arr[i] >= k)
        //    {
        //        check = arr[i];
        //        checkIndex = i;
        //        break;
        //    }
        //}
        //Console.WriteLine(check + "" + checkIndex);
        //// ver. 1 ends here


        // ver. 2 - with binary search - thanks to K. Dikov

        int theNumber = Array.BinarySearch(arr, k);
        Console.WriteLine(theNumber);
        Console.WriteLine(~theNumber);
        if (theNumber < 0)
        {
            Console.WriteLine("The largest number, that is equal ot smaller than wanted number is: " + arr[~theNumber - 1] );
        }
        else if (~theNumber == 0)
        {
            Console.WriteLine("No way, try again.");
        }
        else
        {
            Console.WriteLine("The largest number, that is equal or smaller than wanted number, is : " + arr[theNumber]);
        }
    }
}

