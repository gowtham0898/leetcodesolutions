public class Solution {
    public int NumIslands(char[][] grid) {
        HashSet<(int,int)> conatins = new();
        int row = grid.Length;
        int col = grid[0].Length;
        int island = 0;
        for(int r = 0; r < row; r++){
            for(int c = 0; c < col; c++){
                if(grid[r][c] == '1' && !conatins.Contains((r,c))){
                    BFS(r,c,conatins,grid);
                    island ++;
                }
            }
        }
        return island;
    }

    private void BFS(int r1, int c1,HashSet<(int,int)> conatins, char[][] grid){
        Queue<(int,int)> queue = new();
        queue.Enqueue((r1,c1));
        conatins.Add((r1,c1));
        while(queue.Count >0){
            var (r,c) = queue.Dequeue();

        if(r > 0 && !conatins.Contains((r-1,c)) && grid[r -1][c] == '1'){
        conatins.Add((r-1,c));
        queue.Enqueue(((r-1,c)));
        }
        if(c < grid[0].Length -1 && !conatins.Contains((r,c+1))&& grid[r][c+1] == '1'){
            conatins.Add((r,c+1));
            queue.Enqueue(((r,c+1)));
        }
        if(r < grid.Length -1 && !conatins.Contains((r+1,c)) && grid[r +1][c] == '1'){
            conatins.Add((r+1,c));
            queue.Enqueue(((r+1,c)));
        }
        if(c > 0 && !conatins.Contains((r,c-1)) && grid[r][c-1] == '1'){
            conatins.Add((r,c-1));
            queue.Enqueue(((r,c-1)));
        }
        }
                
    }
}