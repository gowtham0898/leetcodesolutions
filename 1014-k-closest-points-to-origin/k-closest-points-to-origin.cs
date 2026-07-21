public class Solution {

    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> max_heap = new();
        foreach (var point in points){
                int x = point[0];
                int y = point[1];
            int sum = x*x + y*y;
             max_heap.Enqueue(point,-sum);  
             if(max_heap.Count > k){
                max_heap.Dequeue();
             } 
        }
        int[][] res = new int[k][];
       int i = 0;

        while(max_heap.Count >  0)
        {
            res[i] = max_heap.Dequeue();
            i++;
        }
        return res;
     }
    // public int[][] KClosest(int[][] points, int k) {
    //     PriorityQueue<int[],int> min_heap = new();
    //     foreach (var point in points){
    //             int x = point[0];
    //             int y = point[1];
    //         int sum = x*x + y*y;
    //          min_heap.Enqueue(point,sum);   
    //     }
    //     int[][] res = new int[k][];
    //    int i = 0;

    //     while(k > 0)
    //     {
    //         res[i] = min_heap.Dequeue();
    //         i++;
    //         k--;
    //     }
    //     return res;
    // }
}