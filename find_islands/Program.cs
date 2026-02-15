//  
// Given grid where "1" - island, "0" - water, return the number of islands
// isl is connecting by "1" in horizontal and vertical
//
// int[][] grid = [
//     [1, 1, 1, 1, 0],
//     [1, 1, 0, 1, 0],
//     [1, 1, 0, 0, 0],
//     [0, 0, 0, 0, 0],
// ];
//
// Output 1
//
// int[][] grid2 = [
//     [1, 1, 0, 0, 0],
//     [1, 1, 0, 0, 0],
//     [0, 0, 0, 1, 0],
//     [1, 1, 0, 0, 0],
// ];
//
// Output 3

int NumIslands(char[][] grid) {
    var islands = 0;
    var i = 0;
    var j = 0;

    for (i = 0; i < grid.Length; i++)
    {
        for (j = 0; j < grid[i].Length; j++) 
        {
            if (grid[i][j] == '1')
            {
                MarkVisited(grid, i, j);
                islands++;
            }
        }
    }
    
    return islands;
}

void MarkVisited(char[][] grid, int i, int j)
{
    if (grid[i][j] != '1') return;
    
    grid[i][j] = '2';
    
    if (grid[i].Length-1 >= j + 1 && grid[i][j + 1] == '1')
        MarkVisited(grid, i, j + 1);
        
    if (grid.Length-1 >= i + 1 && grid[i + 1][j] == '1')
        MarkVisited(grid, i + 1, j);
                
    if (j > 0 && grid[i][j - 1] == '1')
        MarkVisited(grid, i, j - 1);
        
    if (i > 0 && grid[i - 1][j] == '1')
        MarkVisited(grid, i - 1, j);
}

char[][] grid = [
    ['1', '1', '1'],
    ['0', '1', '0'],
    ['1', '1', '1']
];

Console.WriteLine(NumIslands(grid));

