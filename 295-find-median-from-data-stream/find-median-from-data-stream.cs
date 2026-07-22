public class MedianFinder
{
    private readonly PriorityQueue<int, int> min_heap;
    private readonly PriorityQueue<int, int> max_heap;

    public MedianFinder()
    {
        min_heap = new();
        max_heap = new();
    }

    public void AddNum(int num)
    {
        max_heap.Enqueue(num, -num);

        int value = max_heap.Dequeue();
        min_heap.Enqueue(value, value);
        if(min_heap.Count > max_heap.Count){
            int val = min_heap.Dequeue();
            max_heap.Enqueue(val,-val);    
        }
        // alternative way 
        // if (min_heap.Count > 0 && max_heap.Peek() > min_heap.Peek())
        // {
        //     int value = max_heap.Dequeue();
        //     min_heap.Enqueue(value, value);
        // }

        // if (max_heap.Count > min_heap.Count + 1)
        // {
        //     int value = max_heap.Dequeue();
        //     min_heap.Enqueue(value, value);
        // }
        // else if (min_heap.Count > max_heap.Count + 1)
        // {
        //     int value = min_heap.Dequeue();
        //     max_heap.Enqueue(value, -value);
        // }
    }

    public double FindMedian()
    {
        if(max_heap.Count == min_heap.Count){
            return (max_heap.Peek() + min_heap.Peek())/2.0;
        }
        return max_heap.Peek();
        // alternative
        // if (max_heap.Count == min_heap.Count)
        // {
        //     return (max_heap.Peek() + min_heap.Peek()) / 2.0;
        // }

        // return max_heap.Count > min_heap.Count
        //     ? max_heap.Peek()
        //     : min_heap.Peek();
    }
}