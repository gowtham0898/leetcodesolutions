public class MedianFinder {
    private readonly PriorityQueue<int,int> max_que;
    private readonly PriorityQueue<int,int> min_que;
    public MedianFinder() {
        max_que = new();
        min_que = new();
    }
    
    public void AddNum(int num) {
        max_que.Enqueue(num,-num);
        if(max_que.Count > min_que.Count){
            var  min = max_que.Dequeue();
            min_que.Enqueue(min, min);
        }

        if(min_que.Count >= max_que.Count +1){
            var max = min_que.Dequeue();
            max_que.Enqueue(max, -max);
        }
    }
    
    public double FindMedian() {
          if(max_que.Count == min_que.Count){
            return (max_que.Peek() + min_que.Peek()) /2.0;
          }  
          return max_que.Peek();
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */