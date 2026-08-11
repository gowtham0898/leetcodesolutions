public class Solution {
    public int NumIslands(char[][] grid) {
        int is_land= 0;
         HashSet<(int,int)> set = new();
        for(int r = 0; r < grid.Length; r++){
            for(int c = 0; c < grid[0].Length; c++){
                if(grid[r][c] =='1' && !set.Contains((r,c))){
                         DFS(r,c,grid,set);
                     is_land++;    
                }
               
            }
        }
        return is_land;
    }

    public void DFS(int r, int c, char[][] grid, HashSet<(int,int)> set){
        if(r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length ||
           set.Contains((r,c)) || grid[r][c] =='0'){
            return ;
           }
           set.Add((r,c));
                     DFS(r+1,c,grid,set);
                    DFS(r-1,c,grid,set);
                    DFS(r,c+1,grid,set);
                    DFS(r,c-1,grid,set);                       
    }
}