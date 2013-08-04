//Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements.


using System;

class Task02MaxSquare
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows of your matrix : ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the columns of your matrix : ");
        int c = int.Parse(Console.ReadLine());
        int[,] matrix = new int[r, c];
            
        // IF YOU WANT TO ENTER THE VALUES OF THE MATRIX'S MEMBERS< UNCOMMENT BELOW AND COMMENT THE RANDOM PART

        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("Please, enter value for the element on position {0} : {1} : ", row, col);
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}

        //RANDOM PART STARTS HERE
        Random rand = new Random();
        for (int row = 0; row < matrix.GetLength(0); row++)
		{
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
                    matrix[row, col] = rand.Next(1, 101);
			}
		}
        //RANDOM PART ENDS HERE
        Console.WriteLine("Your matrix looks like this : ");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("|");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 5} |", matrix[row, col]);
            }
            Console.WriteLine();
        }
        //find the best value
        int bestPlatform = int.MinValue;
        int current;
        int indX = 0;
        int indY = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                current = matrix[row, col] + matrix[row + 1, col]
                    + matrix[row, col + 1] + matrix[row + 1, col + 1];
                if (current > bestPlatform)
                {
                    bestPlatform = current;
                    indX = col;
                    indY = row;
                }
            }
        }
        // print the best platform
        Console.WriteLine();
        Console.WriteLine("And the best platform is :");
        Console.WriteLine();
        for (int row = indY; row < indY + 2; row++)
        {
            Console.Write("|");
            for (int col = indX; col < indX + 2; col++)
            {
                Console.Write("{0, 5} |", matrix[row, col] );
            }
            Console.WriteLine();
        }
    }
}

