public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new();
        foreach (int n in nums) {
            pq.Enqueue(n, n);

            if (pq.Count > k) {
                pq.Dequeue();
            }
        }

        return pq.Peek();
    }
}