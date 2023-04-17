namespace MazeRunner.BL
{
    public class ThePathFinder : IPathFinder
    {
        public string MazeRunner(int[,] maze, string[] directions)
        {
            try
            {
                int row = 0;

                int column = 0;


                for (int i = 0; i < maze.GetLength(0); i++)
                {
                    for (int j = 0; j < maze.GetLength(1); j++)
                    {
                        if (maze[i, j] == 2)
                        {
                            row = i;

                            column = j;

                            break;
                        }
                    }
                }

                foreach (string direction in directions)
                {
                    switch (direction)
                    {
                        case "N":
                            row -= 1;
                            break;

                        case "S":
                            row += 1;
                            break;

                        case "W":
                            column -= 1;
                            break;

                        case "E":
                            column += 1;
                            break;
                    }

                    if (maze[row, column] == 1)
                    {
                        return "Dead";
                    }

                    if (maze[row, column] == 3)
                    {
                        return "Finish";
                    }
                }
                return "Lost";
            }

            catch
            {
                return "Dead";
            }
        }
    }
}