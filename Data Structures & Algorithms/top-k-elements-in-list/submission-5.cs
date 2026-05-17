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
