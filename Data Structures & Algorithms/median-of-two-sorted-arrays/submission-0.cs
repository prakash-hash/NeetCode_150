public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // Always binary search the smaller array
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;

        int left = 0;
        int right = m;

        while (left <= right)
        {
            int partitionA = (left + right) / 2;
            int partitionB = (m + n + 1) / 2 - partitionA;

            int maxLeftA = (partitionA == 0) ? int.MinValue : nums1[partitionA - 1];
            int minRightA = (partitionA == m) ? int.MaxValue : nums1[partitionA];

            int maxLeftB = (partitionB == 0) ? int.MinValue : nums2[partitionB - 1];
            int minRightB = (partitionB == n) ? int.MaxValue : nums2[partitionB];

            // Correct partition
            if (maxLeftA <= minRightB && maxLeftB <= minRightA)
            {
                if ((m + n) % 2 == 0)
                {
                    return (Math.Max(maxLeftA, maxLeftB) +
                            Math.Min(minRightA, minRightB)) / 2.0;
                }
                else
                {
                    return Math.Max(maxLeftA, maxLeftB);
                }
            }
            // Move left
            else if (maxLeftA > minRightB)
            {
                right = partitionA - 1;
            }
            // Move right
            else
            {
                left = partitionA + 1;
            }
        }

        throw new InvalidOperationException();
    }
}