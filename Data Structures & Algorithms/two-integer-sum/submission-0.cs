public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0;
        int j = 1;
        int[] ans = new int[2];

        for (i = 0; i < nums.Length - 1; i++) {
            for (j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    ans = new int[] {i, j};
                }
            }
        }
        return ans;
    }
}