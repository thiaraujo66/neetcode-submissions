public class Solution {
    public string RemoveDuplicates(string s, int k) {
        var stack = new Stack<(char ch, int count)>();

        foreach (char c in s) {
            if (stack.Count > 0 && stack.Peek().ch == c) {
                var top = stack.Pop();
                top.count++;

                if (top.count < k)
                    stack.Push(top);
            } else {
                stack.Push((c, 1));
            }
        }

        var sb = new StringBuilder();
        foreach (var (ch, count) in stack.Reverse())
            sb.Append(ch, count);

        return sb.ToString();
    }
}