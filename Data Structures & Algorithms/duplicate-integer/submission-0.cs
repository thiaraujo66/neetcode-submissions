public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>(nums);
        
        if (nums.Length > seen.Count)
            return true;
        
        return false;
    }
}