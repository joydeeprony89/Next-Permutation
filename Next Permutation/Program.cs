public class Solution {
    public void NextPermutation(int[] nums) {
      // Example -  5 6 9 8 2 1 answer is 5 8 1 2 6 9
      // we have to find next bigger no than  5 6 9 8 2 1
      // we can not make a bigger no from the last 4 nos
      // 5 6 - last 4 nos 9 8 2 1 already sorted in desc, so will check the previous one
      // 5 => 6 9 8 2 1, from these 5 nos what is the next bigger no => 8 1 2 6 9 and the answer is => 5 8 1 2 6 9 
      // three steps process
      // Step 1 - start from the end of the array and find an element where nums[i] < nums[i+1]
      // which is nothing but the breakpoint where array elements are started getting decrease.
      // Step 2 - search again from the end , find an element where its greater than nums[i], nums[i] is the element found at step 1
      // Step 3 - Swap step 1 and step 2 elements
      // Step 4 - reverse everyting after nums[i](nums[i], i found at step 1)
      
      // Step 1
      int index1 = -1;
      for(int i = nums.Length - 2; i >= 0 ; i--){
        if(nums[i] < nums[i+1]){
          index1 = i;
          break;
        }
      }
      
      // Step 2
      if(index1 >= 0) {
        int max = nums[index1];
        int index2 = -1;
        for(int i = nums.Length -1; i >= 0; i--){
          if(nums[i] > max){
            index2 = i;
            break;
          }
        }
      
        // Step 3
        int temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
      }
      
      // Step 4
      int si = index1 + 1;
      int sj = nums.Length - 1;
      
      while(si < sj){
        int tmp = nums[si];
        nums[si] = nums[sj];
        nums[sj] = tmp;
        si++; sj--;
      }
    }
}
