public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] count = new int[26];

            foreach (char c in s) {
                count[c - 'a'] += 1;
            }

            string key = string.Join(",", count);

            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            
            res[key].Add(s);
        }

        return res.Values.Cast<List<string>>().ToList();
    }
}
