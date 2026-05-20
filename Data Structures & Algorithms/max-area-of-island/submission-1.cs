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

/*
Common Pitfalls
Forgetting to Mark Cells as Visited
A common mistake is not marking cells as visited before or immediately after processing them. This leads to infinite recursion in DFS or infinite loops in BFS, as the same cell gets added to the queue or call stack repeatedly. Always mark a cell as visited (either by using a separate visited set or by modifying the grid value to 0) before exploring its neighbors.

Incorrect Boundary Checks
Failing to properly check grid boundaries before accessing grid[r][c] causes index-out-of-bounds errors. The order of conditions matters: always check r >= 0 && r < ROWS && c >= 0 && c < COLS before checking grid[r][c]. Short-circuit evaluation prevents the array access when indices are invalid.

Counting Area Incorrectly in BFS
In BFS, a subtle bug occurs when you increment the area count at the wrong time. The area should be incremented when a cell is added to the queue and marked as visited, not when it is dequeued. If you increment when dequeuing, you may count the same cell multiple times if it gets added to the queue from different neighbors before being processed.
*/