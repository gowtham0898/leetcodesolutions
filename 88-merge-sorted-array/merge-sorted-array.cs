public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
    int j = 0;
    for(int i = 0; i < nums1.Length; i++){
        if(nums1[i]==0)
        {
            if(j < n){
            nums1[i] = nums2[j];
            
                j++;
            }
        }
    }
    Array.Sort(nums1); // nlogn

    }
}