public class MyHashSet
{
    private const int SIZE = 1000;
    private List<int>[] set;

    public MyHashSet()
    {
        set = new List<int>[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            set[i] = new List<int>();
        }
    }

    private int Hash(int key)
    {
        return key % SIZE;
    }

    public void Add(int key)
    {
        int index = Hash(key);
        var bucket = set[index];
        
        if (!bucket.Contains(key))
        {
            bucket.Add(key); // Add key if it doesn't exist
        }
    }

    public bool Contains(int key)
    {
        int index = Hash(key);
        var bucket = set[index];
        
        return bucket.Contains(key); // Check if key exists in the bucket
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        var bucket = set[index];
        
        if (bucket.Contains(key))
        {
            bucket.Remove(key); // Remove the key if it exists
        }
    }
}
