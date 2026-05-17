public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int> res = new List<int>();
        PriorityQueue<int,int> heap = new PriorityQueue<int,int>();

        foreach(int num in nums){
            count[num] = count.GetValueOrDefault(num)+1;
        }

        foreach(var kvp in count){
            heap.Enqueue(kvp.Key, kvp.Value);
            if(heap.Count > k){
                heap.Dequeue();
            }
        }

        for(int i = 0; i < k; i++){
            res.Add(heap.Dequeue());
        }
        return res.ToArray();
    }
}
