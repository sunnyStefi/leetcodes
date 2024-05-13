using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution(); 
        // int[] nums = { 1, 1, 3, 4, 4 }; 
        // int[] nums = { 1, 1, 2, 2, 3, 4, 4 }; 
        int[] nums = {1,3,5,6}; 
        int result = solution.SearchInsert(nums, 7);
        Console.WriteLine("Result: " + result); 
    }
}

public class Solution {
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