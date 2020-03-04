using System;

namespace MatrixExample
{
    class Program
    {
        
        
        static void Main(string[] args)
        {

            int[,] matrix1 = new int[,] {{2,3},{4,0}};
            int[,] matrix2 = new int[,] {{1,1},{0,0}};
            Matrix mat1 = new Matrix(matrix1);
            Matrix mat2 = new Matrix(matrix2);
            mat1.PrintMatrix(mat1.mat);  
            Console.WriteLine(); 
            mat2.PrintMatrix(mat2.mat);
            Console.WriteLine();


            int[,] ans = mat1.AddMatrices( mat1.mat,mat2.mat);
            Console.WriteLine("The sum of the matrices: ");
            mat1.PrintMatrix(ans);
        }
    }
}
