public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var minHeap = new PriorityQueue<int[], int>();

        foreach (var point in points)
        {
            int dist = (point[0] * point[0]) + (point[1] * point[1]);

            minHeap.Enqueue(point, dist);
        }

        var res = new int[k][];
        for (int i = 0; i < k; i++)
        {
            res[i] = minHeap.Dequeue();
        }

        return res;
    }
}
