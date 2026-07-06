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

/*
Common Pitfalls
Computing Actual Distance with Square Root
Using sqrt(x^2 + y^2) is unnecessary and introduces floating-point precision issues. Since we only compare relative distances, squared distance x^2 + y^2 preserves ordering and avoids costly square root operations.

Using the Wrong Heap Type
For the heap approach, using a min-heap requires extracting k elements at the end, while a max-heap of size k naturally keeps the k closest. Mixing these up leads to incorrect results or inefficient solutions that maintain more elements than needed.

Integer Overflow in Distance Calculation
When coordinates can be large (up to 10^4), squaring them produces values up to 10^8. While this fits in a 32-bit integer, summing two such values approaches the limit. In languages with overflow concerns, ensure your distance calculation uses appropriate integer types.
*/