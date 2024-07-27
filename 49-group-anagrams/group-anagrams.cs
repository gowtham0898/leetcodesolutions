public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> result = new List<IList<string>>();
        IDictionary<string, IList<string>> keyValuePairs = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            IList<string> subString = new List<string>();
            var value = strs[i].ToCharArray();
            Array.Sort(value);

            subString.Add(strs[i]);

            if(keyValuePairs.ContainsKey(new string(value)))
            {
                keyValuePairs[new string(value)].Add(strs[i]);
            }
            else
            {
                keyValuePairs.Add(new string(value), subString);

            }
        }
        foreach(var res in keyValuePairs)
        {
            result.Add(res.Value);
        }
        return result;
    }
}