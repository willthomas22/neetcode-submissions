public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(int num in nums) {
            if (dict.TryGetValue(num, out int outnum))
            {
                dict[num] = outnum + 1;
            }
            else 
            {
                dict[num] = 1;
            }
        }

        int[] retlist = new int[k];
        
        for (int i = 0; i < k; i++) {
            var maxPair = dict.MaxBy(kvp => kvp.Value); 
            retlist[i] = maxPair.Key;
            dict.Remove(maxPair.Key);
        }

        return retlist;
        
    }
}
