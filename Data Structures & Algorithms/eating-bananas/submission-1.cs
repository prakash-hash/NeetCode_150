public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int[] pilesCopy = (int[])piles.Clone();
        Array.Sort(pilesCopy);
        int min = int.MaxValue;
        int l = 1;
        int r = pilesCopy[piles.Length-1];

        while(l <= r){
            int mid = l + (r-l)/2;
            int time = 0;
            
            foreach(int p in pilesCopy){
                int c = p/mid; 
                time += p%mid == 0 ? c : c + 1;

                if(time > h){
                    l = mid + 1;
                    break;
                }
            }

            if(time <= h){
                min = Math.Min(min, mid);
                r = mid - 1;
            }
        }

        return min;
    }
}
