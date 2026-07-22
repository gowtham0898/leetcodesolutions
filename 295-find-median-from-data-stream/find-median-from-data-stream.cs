public class MedianFinder {
 private readonly PriorityQueue<int, int> min_heap;
  private readonly PriorityQueue<int, int> max_heap;
    public MedianFinder() {
        min_heap = new ();
        max_heap = new();
    }
    
    public void AddNum(int num) {
       max_heap.Enqueue(num, -num);
       if(min_heap.Count > 0 && max_heap.Peek() > min_heap.Peek()){
            var large_num = max_heap.Dequeue();
             min_heap.Enqueue(large_num, large_num);
       }   
       int c1 =  max_heap.Count;
       int c2 = min_heap.Count;
       if(Math.Max(c1,c2) - Math.Min(c1,c2) > 1){
        if(c1 > c2){
            int _max = max_heap.Dequeue();
            min_heap.Enqueue(_max,_max);
        }else{
            int _min = min_heap.Dequeue();
             max_heap.Enqueue(_min,-_min);
        }
       } 
    }
    
    public double FindMedian() {
          int c1 =  max_heap.Count;
       int c2 = min_heap.Count;
        if(c1 == c2){

             return (min_heap.Peek() + max_heap.Peek()) / 2.0;   
        }
        else{
            if(c1 > c2){
                return max_heap.Peek();
            }
            else{
                return min_heap.Peek();
            }
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */