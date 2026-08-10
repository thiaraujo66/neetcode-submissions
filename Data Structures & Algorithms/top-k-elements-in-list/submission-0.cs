public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var contagem = new Dictionary<int, int>();
        foreach (int num in nums)
            contagem[num] = contagem.GetValueOrDefault(num, 0) + 1;

        List<int>[] baldes = new List<int>[nums.Length + 1];
        foreach (var par in contagem) {
            int freq = par.Value;
            baldes[freq] ??= new List<int>();
            baldes[freq].Add(par.Key);
        }

        int[] resultado = new int[k];
        int i = 0;
        for (int freq = baldes.Length - 1; freq >= 0 && i < k; freq--) {
            if (baldes[freq] == null) continue;
            foreach (int numero in baldes[freq]) {
                resultado[i++] = numero;
                if (i == k) break;
            }
        }
        return resultado;
    }
}
