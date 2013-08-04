//We are given a matrix of strings of size N x M. 
//Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter the number of rows of your matrix : ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the columns of your matrix : ");
        int c = int.Parse(Console.ReadLine());
        string [,] matrix = new string [r, c];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter your string at position {0},{1} here : ", row + 1, col + 1);
                matrix[row, col] = Console.ReadLine();
            }
        }

        string test = "";
        int counter = 0;
        int bestCount = int.MinValue;
        string bestWord = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                test = matrix[row, col];
                counter = 0;

                for (int testRow = 0; testRow < matrix.GetLength(0); testRow++)
                {
                    for (int testCol = 0; testCol < matrix.GetLength(1); testCol++)
                    {
                        if ((test == matrix[testRow, testCol]))// && (row != testRow) && (col != testCol))
                        {
                            counter++;
                            if (counter > bestCount)
                            {
                                bestCount = counter;
                                bestWord = test;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("The most repeated string in your matrix is \"{0}\", and it is repeated {1} times.",  bestWord, bestCount);
    }
}