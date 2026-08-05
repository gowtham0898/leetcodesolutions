public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> pre_map = new();
        for(int i = 0; i < numCourses; i ++){
            pre_map[i] = new List<int>();
        }
        foreach(var pre in prerequisites){
            int course = pre[0];
            int pre_req = pre[1];
            pre_map[course].Add(pre_req);
        }

        HashSet<int> exist = new();
        for(int course = 0; course < numCourses; course++){
            if(!DFS(course,pre_map,exist)) return false;
        }
        return true;
    }
    private bool DFS(int course,  Dictionary<int, List<int>> pre_map, HashSet<int> exist){
        if(exist.Contains(course)){
            return false;
        }
        if(pre_map[course].Count == 0){
            return true;
        }
        exist.Add(course);
        foreach(var pre in pre_map[course]){
            if(!DFS(pre,pre_map,exist)) return false;            
        }
        exist.Remove(course);
        pre_map[course] = [];
        return true;
    }
}