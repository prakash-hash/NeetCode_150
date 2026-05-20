public class Solution {
	
    public int OrangesRotting(int[][] grid) {
        int time = 0;
		Queue<(int y, int x, int t)> rotten = new();
		for(int i = 0; i < grid.Length; i++){
			for(int j = 0; j < grid[0].Length; j++){
				if(grid[i][j] == 2){
					rotten.Enqueue((i, j, 0));
				}
			}
		}
		
		while(rotten.Count != 0){
			(int y, int x, int t) current = rotten.Dequeue();
			foreach((int y, int x) n in new[]{(0,-1), (0,1), (-1, 0), (1,0)}){
				(int y, int x, int t) newNode = (current.y+n.y, current.x+n.x, current.t+1);
				if( newNode.x >= 0 && newNode.x < grid[0].Length && 
					newNode.y >= 0 && newNode.y < grid.Length  && 
					grid[newNode.y][newNode.x] == 1){
						time = newNode.t;
						rotten.Enqueue(newNode);
						grid[newNode.y][newNode.x] = 2;
					}
			}
		}
		
		foreach(var r in grid){
			foreach(var c in r){
				if(c == 1){
					return -1;
				}
			}
		}
		
		return time;
    }
}