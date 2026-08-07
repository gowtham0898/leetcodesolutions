public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {

        if(!wordList.Contains(endWord)){
            return 0;
        }
        Dictionary<string,List<string>> map = new();
        Queue<string> queue = new();
        HashSet<string> visited = new();
        wordList.Add(beginWord);
        visited.Add(beginWord);
        queue.Enqueue(beginWord);

        foreach(var word in wordList){
            int count = word.Length;
            for(int i = 0; i < count; i++){
               string pattern = word.Substring(0,i)+'*'+word.Substring(i+1);
                if(!map.ContainsKey(pattern)){
                    map[pattern] =  new List<string>();
                }
                map[pattern].Add(word);
            }
        }
        int item = 1;
        while(queue.Count > 0){
            int q_count = queue.Count;
            for(int i = 0; i < q_count; i++){
                var d_que = queue.Dequeue();

                if(d_que == endWord) return item;

                for(int j = 0; j < d_que.Length; j++){
                    string re_pat = d_que.Substring(0,j)+'*'+d_que.Substring(j+1);
                    foreach(var wr in map[re_pat]){
                        if(!visited.Contains(wr)){
                            visited.Add(wr);
                            queue.Enqueue(wr);                            
                        }
                    }
                }
            }
            item++;
        }
        return 0;
    }
}