public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int l = 0;
        int r = n * m - 1;
        
        while(l <= r){
            int mid = l + (r-l)/2;
            int row = mid/m;
            int col = mid%m;
            int num = matrix[row][col];
            if(num == target){
                return true;
            }
            else if(num < target){
                l = mid + 1;
            }
            else{
                r = mid - 1;
            }
        }

        return false;
    }
}
