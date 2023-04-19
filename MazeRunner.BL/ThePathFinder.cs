using System.Security.Cryptography.X509Certificates;

namespace MazeRunner.BL
{
    public class ThePathFinder : IPathFinder
    {
        public string MazeRunner(int[,] maze, string[] directions)
        {
            int row = 0;

            int column = 0;

            var directionsDictionary = new Dictionary<string, (int, int)>()
            {
                {"N", (0, -1) },

                {"S", (0, 1) },

                {"W", (-1, 0) },

                {"E", (1, 0) },
            };

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

            try
            {
                foreach (string direction in directions)
                {
                    //switch (direction)
                    //{
                    //    case "N":
                    //        row -= 1;
                    //        break;

                    //    case "S":
                    //        row += 1;
                    //        break;

                    //    case "W":
                    //        column -= 1;
                    //        break;

                    //    case "E":
                    //        column += 1;
                    //        break;
                    //}

                    var directionsTuple = directionsDictionary[direction];

                    column += directionsTuple.Item1;

                    row += directionsTuple.Item2;

                    if (maze[row, column] == 1)
                    {
                        return "Dead";
                    }

                    if (maze[row, column] == 3)
                    {
                        return "Finish";
                    }
                }
            }

            catch
            {
                return "Dead";
            }

            return "Lost";
        }
    }
}