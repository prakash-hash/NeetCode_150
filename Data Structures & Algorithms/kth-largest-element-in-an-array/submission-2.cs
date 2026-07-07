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

/*

Common Pitfalls
Confusing K-th Largest With K-th Smallest
The problem asks for the k-th largest element, not the k-th smallest. When using sorting, the k-th largest is at index n - k, not at index k - 1. Similarly, in QuickSelect, you must convert to the correct target index. Mixing up these indices is a very common source of off-by-one errors.

Using a Max-Heap Instead of a Min-Heap
For the heap approach, a min-heap of size k is the correct choice because it keeps the smallest of the k largest elements at the top. Using a max-heap would require storing all n elements and extracting k times, which is less efficient. The min-heap approach maintains O(k) space and O(n log k) time.

QuickSelect Worst Case on Sorted Arrays
QuickSelect degrades to O(n^2) time when the pivot choice is consistently poor, such as always picking the last element on an already sorted or reverse-sorted array. This can cause time limit exceeded errors. Using randomized pivot selection or median-of-three pivot selection helps avoid this worst case and keeps the average complexity at O(n).
*/