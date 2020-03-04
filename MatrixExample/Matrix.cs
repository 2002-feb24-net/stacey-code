using System;

namespace MatrixExample
{
    public class Matrix
    {
        //set up a 2d matrix
        public int[,] mat = new int[2,2];
        
        public Matrix(int[,] value)
        {
            for (int i=0; i<2;i++)
            {
                for (int j=0; j<2;j++)
                {
                    mat[i,j] = value[i,j];
                }
            }
        }

        public void SetRow(int[][] matVal)
        {
            
        }
        public int[,] AddMatrices(int[,] mat1, int[,] mat2)
        {
            int[,] sum = {{0,0},{0,0}};
             for (int i=0; i<2;i++)
            {
                for (int j=0; j<2;j++)
                {
                    sum[i,j] = mat1[i,j]+ mat2[i,j];
                }
            }
            return sum;
        }
        public void PrintMatrix(int[,] mat1)
        {
            for (int i=0; i<2;i++)
            {
                Console.Write("|");
                for (int j=0; j<2;j++)
                {
                    Console.Write($"{mat1[i,j]} ");
                     if (j==1)
                {
                    Console.Write("|");
                }
                    
                }
                Console.WriteLine();
               
            }
        }
    }
}