public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int> res = new List<int>();
        List<int>[] freq = new List<int>[nums.Length+1];
        
        foreach(int num in nums){
            count[num] = count.GetValueOrDefault(num)+1;
        }

        for (int i = 0; i < freq.Length; i++){
            freq[i] = new List<int>();
        }

        foreach(var kvp in count){
            freq[kvp.Value].Add(kvp.Key);
        }

        for(int i = freq.Length-1; i > 0; i--){
            if(freq[i].Count == 0){
                continue;
            }
            foreach(int n in freq[i]){
                res.Add(n);
                if(res.Count == k){
                    return res.ToArray();
                }
            }
        }
        
        return res.ToArray();
    }
}

/*Common Pitfalls
Using a Max-Heap Instead of Min-Heap
When keeping track of the top k elements, a min-heap of size k is needed so you can efficiently remove the smallest frequency when the heap exceeds size k. Using a max-heap requires storing all elements and then extracting k times, which is less efficient. The min-heap approach maintains only the k largest frequencies at any time.

Forgetting to Handle Ties in Frequency
When multiple numbers have the same frequency, the order in which they appear in the result may vary. Most problem statements accept any valid ordering, but some solutions incorrectly assume a specific order or break when frequencies are equal. Ensure your comparison function handles equal frequencies gracefully.

Off-By-One in Bucket Sort Index
In bucket sort, frequencies range from 1 to n (the array length), so you need n + 1 buckets indexed 0 to n. A common mistake is creating only n buckets, causing an index out of bounds error when an element appears n times. Always allocate len(nums) + 1 buckets to accommodate all possible frequencies.*/
