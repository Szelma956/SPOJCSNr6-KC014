using System;

namespace KC014
{

    class Matrix
    {
        private int n;
        private int[,] tabA;
        private int[,] tabB;
        private int[,] tabC;

        public Matrix(int n)
        {
            this.tabA = new int[n, n];
            this.tabB = new int[n, n];
            this.tabC = new int[n, n];
            this.n = n;
        }

        public void LoadToMatrixA()
        {
            int k = 0;
            string line = Console.ReadLine();
            string[] storage = line.Split(" ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tabA[i, j] = int.Parse(storage[k]);
                    k++;
                }
            }
        }

        public void LoadToMatrixB()
        {
            int k = 0;
            string line = Console.ReadLine();
            string[] storage = line.Split(" ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tabB[i, j] = int.Parse(storage[k]);
                    k++;
                }
            }
        }

        public void MatrixMultiplication()
        {
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tabC[i, k] += tabA[i, j] * tabB[j, k];
                    }
                }
            }
        }


        public void ConvertAndPrintMatrix()
        {
            string output = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    output = output + tabC[i, j] + " ";
                }
            }

            Console.WriteLine(output);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string line = " ";
            int n;
            while (line != null)
            {
                line = Console.ReadLine();
                if (line != null)
                {
                    n = int.Parse(line);
                    Matrix matrix = new Matrix(n);

                    matrix.LoadToMatrixA();
                    matrix.LoadToMatrixB();
                    matrix.MatrixMultiplication();
                    matrix.ConvertAndPrintMatrix();
                }
            }
        }
    }
}
