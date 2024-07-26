public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        int row = matrix.Length;
        int col = matrix[0].Length;
        int l=0, r = col-1,t =0,b = row-1;

        while(l <= r && t <=b){
            // from l ==> r
            for(int i = l; i <=r;i++){
                result.Add(matrix[t][i]);
            }
            t++;
            //from t ==> b
            for(int i = t ; i <=b; i++){
                result.Add(matrix[i][r]);
            }
            r--;
            // check it is not a row matrix eg: [1,2,3]
            if(t <=b){
            // from r ==> l
            for(int i = r; i >= l;i--)
            {
                result.Add(matrix[b][i]);
            }
            b--;
            }
            if(l<=r){
                // from b ==> t
                for(int i = b ; i >= t;i--){
                    result.Add(matrix[i][l]);
                }
                l++;
            }
        }
        return result;
    }
}