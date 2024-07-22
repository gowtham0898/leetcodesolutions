public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

     int[] result = new int[m + n];
    int l = 0, r = 0, i = 0;
    
    // Merge both arrays
    while (l < m && r < n) {
        if (nums1[l] <= nums2[r]) {
            result[i++] = nums1[l++];
        } else {
            result[i++] = nums2[r++];
        }
    }
    
    // Copy any remaining elements from nums1
    while (l < m) {
        result[i++] = nums1[l++];
    }
    
    // Copy any remaining elements from nums2
    while (r < n) {
        result[i++] = nums2[r++];
    }
    
    // Copy the result back to nums1
    for (i = 0; i < m + n; i++) {
        nums1[i] = result[i];
    }

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