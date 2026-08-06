public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] f = s.ToArray();
        char[] g = t.ToArray();

        if (f.Length != g.Length)
            return false;

        Array.Sort(f);
        Array.Sort(g);

        string sortedF = new string(f);
        string sortedG = new string(g);

        return sortedF == sortedG;
    }
}
