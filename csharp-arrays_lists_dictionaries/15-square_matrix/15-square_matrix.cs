using System;

class Matrix
{
  public static int[,] Square(int[,] myMatrix)
  {
    int rows = myMatrix.GetLength(0);
    int cols = myMatrix.GetLength(1);
    int[,] newMatrix = new int[rows, cols];

    for(int i = 0; i < rows; i++)
    {
      for(int j = 0; j < cols; j++)
      {
        newMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
      }
    }
    return newMatrix;
  }
}




// Write a method that computes the square value of all integers of a matrix.

// Class Name: Matrix
// Prototype: public static int[,] Square(int[,] myMatrix)
// Returns a new matrix containing the square value of all integers of the original matrix