namespace CountingStars;

public static class StarCounter
{
    public static int Count(string[] map)
    {
        var counter = 0;
        var visited = new bool[map.Length, GetMaxRowLength(map)];

        for (int i = 0; i < map.Length; i++) 
        {
            for(int j = 0; j < map[i].Length; j++)
            {
                if (!visited[i, j] && map[i][j] == '*')
                {
                    counter++; 
                    TraverseStar(map, visited, i, j);
                }
            }
        }

        return counter;
    }

    private static int GetMaxRowLength(string[] map) 
    {
        return map.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur).Length; 
    }

    private static void TraverseStar(string[] map, bool[,] visited, int i, int j)
    {
        if (i < 0 || 
            i >= map.Length || 
            j < 0 || 
            j >= map[i].Length)
        {
            return; 
        }

        if (visited[i, j] || 
            map[i][j] == '.') 
        {
            return; 
        }

        visited[i, j] = true;

        TraverseStar(map, visited, i - 1, j);
        TraverseStar(map, visited, i + 1, j);
        TraverseStar(map, visited, i, j - 1);
        TraverseStar(map, visited, i, j + 1);
    }
}