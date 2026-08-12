public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
       if(!wordList.Contains(endWord)){
        return 0;
       } 
       Dictionary<string, List<string>> map = new();
       wordList.Add(beginWord);
       foreach( var word in wordList){
        for(int i = 0; i < word.Length; i++){
            var ptrn = word.Substring(0,i) +'*' + word.Substring(i+1);
            if(!map.ContainsKey(ptrn)){
                map[ptrn] = new List<string>();
            }
            map[ptrn].Add(word);
         }
       }
       Queue<string> que = new();
       HashSet<string> visit = new();
       que.Enqueue(beginWord);
       visit.Add(beginWord);
        int level = 1;
       while(que.Count > 0){
        int qu_c = que.Count;
        for(int c = 0; c< qu_c; c++){
            var wrd = que.Dequeue();
            if(wrd == endWord) return level;
            for(int i = 0; i < wrd.Length; i++){
                string ptr = wrd.Substring(0,i)+'*'+ wrd.Substring(i+1);
                foreach(var wr in map[ptr]){
                    if(visit.Contains(wr)){
                        continue;
                    }
                    visit.Add(wr);
                    que.Enqueue(wr);
                }
            }
        }
        level ++;
       }
       return 0;
    }
}