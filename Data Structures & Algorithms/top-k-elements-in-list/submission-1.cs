public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int[] res = new int[k];

        foreach(int num in nums){
            count[num] = count.GetValueOrDefault(num)+1;
        }

        KeyValuePair<int,int>[] sortedList = count.ToArray();
        Array.Sort(sortedList, (a,b) => b.Value.CompareTo(a.Value));
        
        for(int i = 0; i < k; i++){
            res[i] = sortedList[i].Key;    
        }

        return res; 
    }
}
