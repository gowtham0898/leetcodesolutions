public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        if(image.Length ==0){
            return image;
        }

        HashSet<(int,int)> contain = new();
        Queue<(int,int)> queue = new();
        int row = image.Length;
        int col = image[0].Length;
        contain.Add((sr,sc));
        queue.Enqueue((sr,sc));    
        int original = image[sr][sc];
        if(original == color){
            return image;
        }
        image[sr][sc] = color;
        int[][] directions = {
            new[] {-1,0},
            new[] {0,1},
            new[] {1,0},
            new[] {0,-1}
        };
        while (queue.Count > 0){
            var (r,c) = queue.Dequeue();
            foreach(var dir in directions){
                int new_row = r + dir[0];
                int new_col = c + dir[1];
                if(new_row >= 0 && new_row < row && new_col >= 0 && new_col < col
                 && !contain.Contains((new_row,new_col)) && image[new_row][new_col]== original){
                     contain.Add((new_row,new_col));
                    queue.Enqueue((new_row,new_col));   
                    image[new_row][new_col] = color;
                }                
            }
        }
    return image;
    }
}