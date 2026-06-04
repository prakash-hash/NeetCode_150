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

/*
Common Pitfalls
Using Integer Division Instead of Ceiling
When calculating hours needed per pile, you must round up since Koko spends a full hour even if fewer bananas remain. Using regular integer division gives wrong results.

# Wrong: Integer division rounds down
totalTime += pile // speed

# Correct: Ceiling division
totalTime += math.ceil(pile / speed)
# Or without import:
totalTime += (pile + speed - 1) // speed
Setting Wrong Binary Search Bounds
The minimum speed is 1 (not 0, which would cause division by zero). The maximum speed needed is max(piles) since eating faster than the largest pile provides no benefit.

# Wrong: Starting from 0
l = 0  # Division by zero!

# Wrong: Arbitrary upper bound
r = sum(piles)  # Unnecessarily large

# Correct bounds
l, r = 1, max(piles)
Integer Overflow in Total Time
When summing hours across all piles, the total can exceed 32-bit integer limits for large inputs. Use a long integer type in languages like Java/C++.

// Wrong: May overflow
int totalTime = 0;

// Correct: Use long
long totalTime = 0;
*/
