//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)


using System;

class Task01DifferentMatrixes
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter the wanted size : ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];

        int count = 1;
        // VER. 1
        // this way we give values to our matrix - var. 1
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[col, row] = count;
                count++;
            }
        }
        //this way we print the ver. 1 of our matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("|");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} | ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //now we should set all values of our matrix to zero

        Array.Clear(matrix, 0, size*size);
        // and we fall on the next row of console.
        Console.WriteLine();

        // VER. 2 
        //and now we start making ver. 2 of our matrix by using the same pattern
        count = 1;
        int matrixRow = 0;
        int matrixCol = 0;

        while (count <= Math.Pow(size, 2))
        {
            while (matrixRow < size)
            {
                matrix[matrixRow, matrixCol] = count;
                count++;
                matrixRow++;
            }
            matrixRow--;
            matrixCol++;
            if (matrixCol == size)
            {
                break;
            }
            while (matrixRow >= 0)
            {
                matrix[matrixRow, matrixCol] = count;
                count++;
                matrixRow--;
            }
            matrixCol++;
            matrixRow++;
        }
        // print ver.2 on the console.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("|");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} | ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        // clear the array

        Array.Clear(matrix, 0, size * size);
        count = 1;
        Console.WriteLine();
        // VER. 3

        //start giving values

        for (int row = 0; row <= size - 1; row++)
            for (int col = 0; col <= row; col++)
                matrix[size - row + col - 1, col] = count++;

        for (int row = size - 2; row >= 0; row--)
            for (int col = row; col >= 0; col--)
                matrix[row - col, size - col - 1] = count++;

        // print ver.3 on the console.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("|");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} | ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        // clear the array

        Array.Clear(matrix, 0, size * size);
        count = 1;
        Console.WriteLine();
        // VER. 4
        //start giving values

        int up = 0;
        int down = size - 1;
        int left = 0;
        int right = size - 1;
        count = 1;

        while (count <= size * size)
        {
            //trygwame nadolu po lewiq red
            for (int goDown = up; goDown <= down; goDown++) // trygwame nadolu
            {
                matrix[goDown, left] = count;
                count++;
            }
            left++;
            //trygwame nadqsno po nai-dolniq red
            for (int goRight = left; goRight <= right; goRight++)
            {
                matrix[down, goRight] = count;
                count++;
            }
            down--;
            //trygwame na gore po desniq red
            for (int goUp = down; goUp >= up; goUp--)
            {
                matrix[goUp, right] = count;
                count++;
            }
            right--;
            //trygwame na lqso po nai-gorniq red
            for (int goLeft = right; goLeft >= left; goLeft--)
            {
                matrix[up, goLeft] = count;
                count++;
            }
            up++;
        }
        // print ver.4 on the console.
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("|");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} | ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

