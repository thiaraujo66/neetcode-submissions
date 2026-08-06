public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] f = s.ToArray();
        char[] g = t.ToArray();

        Array.Sort(f);
        Array.Sort(g);

        if (f.Length != g.Length)
            return false;

        string sortedF = new string(f);
        string sortedG = new string(g);

        if (sortedF == sortedG)
            return true;

        return false;
    }
}
