public class Solution {
    public static bool CheckValidNeighbour((int y,int x) node, bool[,] visited, int[][] grid){
		if((node.x < 0 || node.x == grid[0].Length) || (node.y < 0 || node.y == grid.Length)){
		    return false;
	    }
	    if(visited[node.y, node.x] || grid[node.y][node.x] == 0){
		    return false;
	    }

	    return true;
    } 

    public static int BFS((int y,int x) node, bool[,] visited, int[][] grid){
        Queue<(int y, int x)>neighbours = new Queue<(int y, int x)>();
        int area = 1;
        visited[node.y, node.x] = true;
        neighbours.Enqueue(node);
        while(neighbours.Count != 0){
            (int y, int x) currNode = neighbours.Dequeue();
            foreach((int y, int x) n in new[]{(0,-1), (1, 0), (0, 1), (-1, 0) }){
                (int y, int x) newNode = (currNode.y+n.y,currNode.x+n.x);
                if(CheckValidNeighbour(newNode, visited, grid)){
                    neighbours.Enqueue(newNode);
					visited[newNode.y, newNode.x] = true;
                    area++;
                }
            }
        }
        return area;
    }

    public int MaxAreaOfIsland(int[][] grid) {
        bool[,] visited = new bool[grid.Length, grid[0].Length];
        int maxArea = 0;
		for(int i = 0; i < grid.Length; i++){
			for(int j = 0; j < grid[0].Length; j++){
				if(!visited[i,j] && grid[i][j] != 0){
					maxArea = Math.Max(maxArea, BFS((i,j), visited, grid));
				}
			}
		}
		return maxArea;
    }
}