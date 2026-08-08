public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = new();
        foreach(string op in operations){
            int len = scores.Count;
            if(op == "+"){
                scores.Add(scores[len-1]+scores[len-2]);
            }
            else if(op == "C"){
                scores.RemoveAt(len - 1);
            }
            else if(op == "D"){
                scores.Add((scores[len-1])*2);
            }
            else{
                scores.Add(int.Parse(op));
            }
        }

        return scores.Sum();
    }
}