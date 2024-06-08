public class Solution {
    // jagged array  
    //matrix[0].Length (column)
    //matrix.Length (rows)
    public void SetZeroes(int[][] matrix) {
        bool first_row_dirty = false;
        // set 1st row and 1st column as zero if any coresponding elements is zero
        for(int i = 0; i < matrix.Length; i++){
            for(int j = 0; j < matrix[0].Length; j++){
                if(matrix[i][j]==0){
                   matrix[0][j] = 0; // column
                        if(i > 0)
                        {
                            matrix[i][0] = 0; //row
                        }
                        else
                        {
                            first_row_dirty = true;
                        }
                }
                
            }
        }
        for(int r = 1; r < matrix.Length; r++){
            for(int c = 1 ; c < matrix[0].Length ; c++){
                if(matrix[0][c]== 0 || matrix[r][0] == 0){
                    matrix[r][c] = 0;
                }
            }
        }
        // 1st column
            if (matrix[0][0] == 0)
            {
                for (int r = 0; r < matrix.Length; r++)
                {
                    matrix[r][0] = 0;
                }

                
            }
            // 1st row
            if (first_row_dirty == true)
            {
                for (int c = 0; c < matrix[0].Length; c++)
                {
                    matrix[0][c] = 0;
                }
            }
    }
} 