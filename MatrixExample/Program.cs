using System;

namespace MatrixExample
{
    class Program
    { 
        static void Main(string[] args)
        {

            int[,] matrix1 = new int[,] {{2,-3},{4,0}};
            int[,] matrix2 = new int[,] {{1,-1},{0,0}};
            Matrix mat1 = new Matrix(matrix1);
            Matrix mat2 = new Matrix(matrix2);
            //Prin the default matrices
            mat1.PrintMatrix(mat1.mat);  
            Console.WriteLine(); 
            mat2.PrintMatrix(mat2.mat);
            Console.WriteLine();
            //print the negative of matrices
            Console.WriteLine("The negative of the matrices: ");
            int[,] negative1 = mat1.NegateMatrix(mat1.mat);
            mat1.PrintMatrix(negative1);
            Console.WriteLine();
            int[,] negative2 = mat2.NegateMatrix(mat2.mat);
            mat1.PrintMatrix(negative2);
            //transpose of the matrices
            Console.WriteLine("The transpose of the matrices: ");
            int[,] transpose1 = mat1.TransposeMatrix(mat1.mat);
            mat1.PrintMatrix(transpose1);
            Console.WriteLine();
            int[,] transpose2 = mat2.TransposeMatrix(mat2.mat);
            mat1.PrintMatrix(transpose2);


            int[,] ans = mat1.AddMatrices( mat1.mat,mat2.mat);
            Console.WriteLine("The sum of the matrices: ");
            mat1.PrintMatrix(ans);
        }
    }
}
