public class MyHashMap
{
    private const int SIZE = 1000;
    private List<KeyValuePair<int, int>>[] map;

    public MyHashMap()
    {
        map = new List<KeyValuePair<int, int>>[SIZE];
        for (int i = 0; i < SIZE; i++)
        {
            map[i] = new List<KeyValuePair<int, int>>();
        }
    }

    private int Hash(int key)
    {
        return key % SIZE;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);
        var bucket = map[index];
        
        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].Key == key)
            {
                bucket[i] = new KeyValuePair<int, int>(key, value); // Update value if key exists
                return;
            }
        }
        
        bucket.Add(new KeyValuePair<int, int>(key, value)); // Add new key-value pair
    }

    public int Get(int key)
    {
        int index = Hash(key);
        var bucket = map[index];
        
        foreach (var pair in bucket)
        {
            if (pair.Key == key)
            {
                return pair.Value;
            }
        }
        
        return -1; // Key not found
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        var bucket = map[index];
        
        for (int i = 0; i < bucket.Count; i++)
        {
            if (bucket[i].Key == key)
            {
                bucket.RemoveAt(i); // Remove the key-value pair
                return;
            }
        }
    }
}
