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
