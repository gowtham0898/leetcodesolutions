public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {

          DFS(image, sr,sc,color, image[sr][sc]);
          return image;
    }
    private void DFS(int[][] image, int sr, int sc, int color, int original_color){
        if(sr < 0 || sr >= image.Length|| sc< 0 || sc >= image[0].Length ||
           image[sr][sc] == color || original_color != image[sr][sc]){
            return;
           }
           image[sr][sc] = color;
           DFS(image, sr+1,sc,color,original_color);
           DFS(image, sr-1,sc,color,original_color);
           DFS(image, sr,sc+1,color,original_color);
           DFS(image, sr,sc-1,color,original_color);
    }
}