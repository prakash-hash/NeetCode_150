public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = piles.Max();
        int min = r;

        while (l <= r) {
            int mid = l + (r - l) / 2;
            int time = 0;

            foreach (int p in piles) {
                int c = p / mid;
                time += p % mid == 0 ? c : c + 1;
            }

            if (time > h) {
                l = mid + 1;
            }
            else{
                min = mid;
                r = mid - 1;
            }
        }

        return min;
    }
}
