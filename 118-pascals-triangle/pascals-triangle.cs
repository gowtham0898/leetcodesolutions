public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>> ();

        for(int c = 0; c < numRows; c++){
            IList<int> row = new List<int>(new int[c+1]);
            row[0] = 1; // 1st index
            row[row.Count - 1] = 1; // last index
            for( int r = 1; r < c; r++)// exclude 1st and last column
            { 
            row[r] = result[c-1][r-1] + result[c-1][r];
            }
            result.Add(row);
        }
        return result;
    }
}
