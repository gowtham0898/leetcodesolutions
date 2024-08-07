public class Solution {
    public void Rotate(int[][] matrix) {

         int n = matrix.Length;
         //change row to column here 
            for (int i = 0; i < n; i++)
            {
                //trick here y j < i
                for (int j = i; j < n; j++)
                {
                    var temp = matrix[i][j];                
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            // here inter change the column
        //eg: (0,0) ==> (0,2)
            //(1,0) ==> (1,2)
            //(2,0) ==> (2,2)
            // so i will be same only j we need to last always
            for (int i = 0;i < n; i++)
            {
                for(int j = 0; j < n/2;j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - 1 - j];

                    matrix[i][n - 1 - j] = temp;

                }
            }
        // int[][] copy_matrix = new int[matrix.Length][];
        // int n = matrix.Length;
        // for (int i = 0; i < matrix.Length; i++)
        // {
        //     copy_matrix[i] = new int[matrix[i].Length];
        // }
        // for(int i = 0; i < matrix.Length; i++)
        // {
        //     for(int j = 0; j < matrix[i].Length; j++)
        //     {
        //         copy_matrix[j][n - 1 - i] = matrix[i][j];
        //     }
        // }
        // for(int i = 0;i < matrix.Length; i++)
        // {
        //     for(int j = 0;j < matrix[i].Length; j++)
        //     {
        //         matrix[i][j] = copy_matrix[i][j];
        //     }
        // }
    }
}