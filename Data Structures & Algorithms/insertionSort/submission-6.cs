// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        if(pairs.Count == 0){
                return new List<List<Pair>>();
        }
        
        List<List<Pair>> states = new();
        for(int i = 1; i < pairs.Count; i++){
                states.Add(new(pairs));
                Pair p = pairs[i];
                int j = i;
                while(j > 0 && pairs[j-1].Key > p.Key){
                        pairs[j] = pairs[j-1];
                        j--;   
                }
                pairs[j] = p;
        }

        states.Add(pairs);
        return states;
    }
}
