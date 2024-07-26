public class Solution {
    public void Rotate(int[][] matrix) {
        int[][] copy_matrix = new int[matrix.Length][];
        int n = matrix.Length;
        for (int i = 0; i < matrix.Length; i++)
        {
            copy_matrix[i] = new int[matrix[i].Length];
        }
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                copy_matrix[j][n - 1 - i] = matrix[i][j];
            }
        }
        for(int i = 0;i < matrix.Length; i++)
        {
            for(int j = 0;j < matrix[i].Length; j++)
            {
                matrix[i][j] = copy_matrix[i][j];
            }
        }
    }
}