public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int,List<int>> pre_req = new();

        for(int c = 0; c < numCourses; c++){
            pre_req[c] = new List<int>();
        }
        foreach(var cr in prerequisites){           
            pre_req[cr[0]].Add(cr[1]);
        }

        HashSet<int> visit = new();
        for(int cur =0; cur < numCourses; cur++){
                if(!DFS(cur,pre_req,visit)){
                    return false;
                }
        }
        return true;
    }

    private bool DFS(int cur_cr,Dictionary<int,List<int>> pre_req, HashSet<int> visit){
        if(visit.Contains(cur_cr)){
            return false;
        }
        if(pre_req[cur_cr].Count == 0){
            return true;
        }

        visit.Add(cur_cr);
        foreach(var cur in pre_req[cur_cr]){
           if(!DFS(cur,pre_req,visit)){
            return false;
           }
        }
     visit.Remove(cur_cr);
    pre_req[cur_cr] = [];
    return true;
    }
}