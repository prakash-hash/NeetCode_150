public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        LinkedList<int> deque = new();
        List<int> result = new ();

        for(int i = 0; i < nums.Length; i++){
            if(deque.First != null && deque.First.Value <= i - k){
                deque.RemoveFirst();
            }

            while(deque.First != null && nums[deque.Last.Value] <= nums[i]){
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if(i >= k - 1){
                result.Add(nums[deque.First.Value]);
            }
        } 
        
        return result.ToArray();
    }
}


/*
Common Pitfalls
Storing Values Instead of Indices in the Deque
When using the deque approach, a common mistake is storing the actual values rather than their indices. Storing values makes it impossible to determine when an element has left the window, since you cannot compare positions. Always store indices in the deque and use nums[index] to access values.

Incorrect Window Boundary Checks
Many solutions fail by using wrong conditions for when to start recording results or when to shrink the window. The first valid window exists when right >= k - 1 (or equivalently right + 1 >= k). Off-by-one errors here cause either missing the first window's maximum or including results before the window is fully formed.

Not Maintaining Decreasing Order in Deque
The deque must maintain indices in decreasing order of their corresponding values. A common bug is using <= instead of < when comparing values before popping, or forgetting to pop elements altogether. This results in the front of the deque not representing the actual maximum. Always pop from the back while nums[deque.back()] < nums[current].

Forgetting to Handle the Output Array Size
The number of windows is n - k + 1, not n or n - k. Allocating an output array of the wrong size leads to index out of bounds errors or missing results. This is especially problematic when k equals the array length, where there should be exactly one result.

Incorrect Segment Tree Range Queries
When using segment trees, a frequent mistake is confusing inclusive versus exclusive range boundaries. The query range [i, i + k - 1] is inclusive on both ends for a window starting at index i. Mixing up these boundaries causes queries to include elements outside the window or miss elements at the boundaries.
*/