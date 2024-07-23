public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
    int l = 0,r = 0,i =0;
    int[] result = new int[m + n];

    while(l < m && r < n){
        if(nums1[l] <= nums2[r]){
            result[i] = nums1[l];
            i++;l++;
        }
        else{
            result[i] = nums2[r];
            i++;r++;
        }
    }

    while(r < n){
            result[i] = nums2[r];
            i++;r++;
    }
    
    while(l<m){
        result[i] = nums1[l];
        i++;l++;
    }
    for(int j = 0;j < m+n; j++){
        nums1[j] = result[j];
    }

    // timecomplexicity O(m+n) and spaceComplexicity O(M+N)
    // int j = 0;
    // for(int i = 0; i < nums1.Length; i++){
    //     if(nums1[i]==0)
    //     {
    //         if(j < n){
    //         nums1[i] = nums2[j];
            
    //             j++;
    //         }
    //     }
    // }
    // Array.Sort(nums1); // nlogn

    }
}