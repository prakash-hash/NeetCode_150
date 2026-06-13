public class Solution {
    public int LastStoneWeight(int[] stones) {
        if(stones.Length == 1){
            return stones[0];
        }
        
        if(stones.Length == 2){
            return Math.Abs(stones[0]-stones[1]);
        }
        var maxHeapComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
        PriorityQueue<int, int> pq = new(maxHeapComparer);
        foreach(var st in stones){
            pq.Enqueue(st, st);
        }

        while(pq.Count > 1){
            int a = pq.Dequeue();
            int b = pq.Dequeue();
            int diff = a - b;
            pq.Enqueue(diff, diff);
        }

        return pq.Dequeue();

    }
}
