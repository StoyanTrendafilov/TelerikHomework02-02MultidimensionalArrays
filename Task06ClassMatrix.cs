//* Write a class Matrix, to holds a matrix of integers. 
//Overload the operators for adding, subtracting and multiplying of matrices, 
//indexer for accessing the matrix content and ToString().


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ClassMatrixAndMethod
{
    class Matrix
    {
        private int[,] a;
        private int rows;
        private int cols;

        public Matrix(int[,] a)
        {
            this.a = a;
            this.rows = a.GetLength(0);
            this.cols = a.GetLength(1);
        }

        public Matrix(int rows = 0, int cols = 0)
        {
            this.rows = rows;
            this.cols = cols;
            a = new int[rows, cols];
        }

        public void PrintOnConsole()
        {
            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    Console.Write("{0,5}", a[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (b.rows != a.rows || b.cols != a.cols)
            {
                throw new System.InvalidOperationException("Cannot add matrices from different types.");
            }
            else
            {
                Matrix result = new Matrix(b.rows, b.cols);
                for (int row = 0; row < b.rows; row++)
                {
                    for (int col = 0; col < b.cols; col++)
                    {
                        result.a[row, col] = b.a[row, col] + a.a[row, col];
                    }
                }
                return result;
            }
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (b.rows != a.rows || b.cols != a.cols)
            {
                throw new System.InvalidOperationException("Cannot add matrices from different types.");
            }
            else
            {
                Matrix result = new Matrix(b.rows, b.cols);
                for (int row = 0; row < b.rows; row++)
                {
                    for (int col = 0; col < b.cols; col++)
                    {
                        result.a[row, col] = a.a[row, col] - b.a[row, col];
                    }
                }
                return result;
            }
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.cols != b.rows)
            {
                throw new System.InvalidOperationException("Cannot add matrices from different types.");
            }
            else
            {
                Matrix result = new Matrix(a.rows, b.cols);
                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        for (int p = 0; p < a.cols; p++)
                        {
                            result.a[row, col] += (a.a[row, p] * b.a[p, col]);
                        }
                    }
                }
                return result;
            }
        }

        public object this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0)
                {
                    throw new System.IndexOutOfRangeException("Cannot work with negative indecies");
                }
                return this.a[i, j];
            }
            set
            {
                if (i < 0 || j < 0)
                {
                    throw new System.IndexOutOfRangeException("Cannot work with negative indecies");
                }
                this[i, j] = value;
            }
        }

        public int[,] Values
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
                this.rows = a.GetLength(0);
                this.cols = a.GetLength(1);
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int row = 0; row < this.a.GetLength(0); row++)
            {
                for (int col = 0; col < this.a.GetLength(1); col++)
                {
                    s += this.a[row, col];
                    s += '\t';
                }
                s += '\n';
            }
            return s;
        }
    }

    static void Main(string[] args)
    {
        int[,] x = new int[,]
        {
            { 1, 2, 3, 4},
            { 5, 6, 7, 8},
            { 9,10,11,12},
            {13,14,15,16},
            {17,18,19,20}
        };

        int[,] y = new int[,]
        {
            { 100, 100, 100, 100},
            {1000,1000,1000,1000},
            {  10,  10,  10,  10},
            { -10, -10, -10, -10},
            {   0,   0,   0,   0}
        };

        Matrix matrix1 = new Matrix(x);
        Matrix matrix2 = new Matrix(y);
        Matrix u = new Matrix();
        Matrix v = new Matrix(

       new int[,]{
                    {2,-3,4,5},
                    {1,0,9,-1},
                    {6,1,2,7}
                 });

        u.Values = new int[,]{
            {1,2,3},
            {7,1,-1},
            {9,0,6},
            {2,5,-2},
            {10,0,4}
        };


        Console.WriteLine("Testing     A + B");
        Console.WriteLine();
        Matrix matrix = matrix1 + matrix2;
        matrix.PrintOnConsole();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Testing     A - B");
        Console.WriteLine();
        matrix = matrix1 - matrix2;
        matrix.PrintOnConsole();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Testing     A * B");
        Console.WriteLine();
        matrix = u * v;
        matrix.PrintOnConsole();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Testing ToString");
        Console.WriteLine(matrix.ToString());

        Console.WriteLine("Testing Indexer");
        Console.WriteLine(matrix[2, 2] + " " + u[4, 0]);
    }
}