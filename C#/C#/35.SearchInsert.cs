public class SearchInsertClass {

     public int SearchInsert(int[] nums, int target) {
        int pos = 0;
        for(int i=0; i< nums.Length; i++){
            int current = nums[i];
            if (current == target){
                return i;
            }
            if (target < current){
                return i;
            }
            if (target > current && i==nums.Length-1){
                return nums.Length;
            }
        }

        return pos;
    }
}