public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        for(int i = 0; i < n; i++){
            int l = 0, r = m - 1; 
            while(l <= r){
                if(target > matrix[i][m-1]){
                    break;
                }
                int mid = (l+r)/2;
                int curr = matrix[i][mid];
                if(curr == target){
                    return true;
                }
                else if(curr < target){
                    l = mid + 1;
                }
                else{
                    r = mid-1;
                }
            }
            
        }

        return false;
    }
}
