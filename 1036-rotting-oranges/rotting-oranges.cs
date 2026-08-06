public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int,int)> queue = new();
        int fresh = 0;
        int time = 0;
        for(int r = 0; r < grid.Length; r++){
            for(int c = 0; c < grid[0].Length; c++){
                if(grid[r][c] == 1) fresh++;
                 if(grid[r][c] == 2) queue.Enqueue((r,c));
            }
        }
        int[][] directions = {
            new[] {0,1},
            new[] {0,-1},
            new[] {1,0},
            new[] {-1,0}
        };
        while(queue.Count > 0 && fresh > 0){
            int q_count  = queue.Count;
            for(int i = 0; i < q_count; i++){
                var (r,c) = queue.Dequeue();
                foreach(var dir in directions){
                    int new_row = r + dir[0];
                    int new_col = c + dir[1];
                    if(new_row >= 0 && new_row < grid.Length &&
                       new_col >= 0 && new_col < grid[0].Length && 
                       grid[new_row][new_col] == 1)
                       {
                        grid[new_row][new_col] = 2;
                        fresh--;
                        queue.Enqueue((new_row,new_col));
                       }
                }
            }
            time++;
        }
        return fresh ==0 ? time:-1;
    }
}