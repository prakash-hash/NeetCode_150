public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new();
        foreach(int n in nums){
            pq.Enqueue(n, -n);
        }

        for(int i = 0; i < k - 1; i++){
            pq.Dequeue();
        }

        return pq.Dequeue();
    }
}
