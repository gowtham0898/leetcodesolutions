public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int,int> currentGreaterMap = new Dictionary<int,int>();
        Stack<int> stack = new Stack<int>();
        for(int i = nums2.Length - 1 ; i >= 0 ;i--){
            int current = nums2[i];

            while(stack.Count > 0 && stack.Peek() < current)
            {
                stack.Pop();
            }

            currentGreaterMap[current] = stack.Count > 0 ? stack.Peek() : -1;
            stack.Push(current);
        }
        int[] result = new int[nums1.Length];

        for(int j = 0 ; j < nums1.Length ; j++){
            result[j] = currentGreaterMap[nums1[j]];
        }
        
        return result;
    }
}