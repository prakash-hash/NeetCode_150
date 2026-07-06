public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double>pq = new();
        int[][] result = new int[k][];
        foreach(int[] p in points){
                pq.Enqueue(p, Math.Sqrt(p[0]*p[0] + p[1]*p[1]));
        }

        for(int i = 0; i < k; i++){
                result[i] = pq.Dequeue();
        }

        return result;
    }
}
