public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
        List<int> retorno = new();
        Dictionary<int, int> keyValue = new();
        for (int i = 0; i < nums.Length; i++)
        {
            keyValue.Add(i, nums[i]);
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!keyValue.ContainsValue(i))
                retorno.Add(i);
        }

        return retorno;
    }
}