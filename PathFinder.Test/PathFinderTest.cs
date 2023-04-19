using MazeRunner.BL;

namespace PathFinder.Test
{
    public class PathFinderTest
    {
        [Fact]
        public void MazeRunnerSuccessTest1()
        {
            //arrange
            IPathFinder finder = new ThePathFinder();

            var mapInput = new int[,]
            {
                {1,1,1,1,1,1,1},
                {1,0,0,0,0,0,3},
                {1,0,1,0,1,0,1},
                {0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1},
                {1,0,0,0,0,0,1},
                {1,2,1,0,1,0,1}
            };

            var directionInput = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" };

            string expected = "Finish";
            //act

            string actual = finder.MazeRunner(mapInput, directionInput);


            //assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void MazeRunnerOutOfBounds()
        {
            //arrange
            IPathFinder finder = new ThePathFinder();

            var mapInput = new int[,]
            {
                {1,1,1,1,1,1,1},
                {1,0,0,0,0,0,3},
                {1,0,1,0,1,0,1},
                {0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1},
                {1,0,0,0,0,0,1},
                {1,2,1,0,1,0,1}
            };

            var directionInput = new string[] { "N","E", "E", "S", "S"};

            string expected = "Dead";
            //act

            string actual = finder.MazeRunner(mapInput, directionInput);


            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MazeRunnerSuccessTest2()
        {
            //arrange
            IPathFinder finder = new ThePathFinder();

            var mapInput = new int[,]
            {
                {1,1,1,1,1,1,1},
                {1,0,0,0,0,0,3},
                {1,0,1,0,1,0,1},
                {0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1},
                {1,0,0,0,0,0,1},
                {1,2,1,0,1,0,1}
            };

            var directionInput = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "W", "E", "S", "N", "E" };

            string expected = "Finish";

            //act
            string actual = finder.MazeRunner(mapInput, directionInput);

            //assert
            Assert.Equal(expected , actual);
        }

        [Fact]
        public void MazeRunnerNewStartingPoint()
        {
            //arrange
            IPathFinder finder = new ThePathFinder();

            var mapInput = new int[,]
            {
                {1,1,1,1,1,1,1},
                {1,0,0,0,0,0,3},
                {1,0,1,0,1,0,1},
                {0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1},
                {2,0,0,0,0,0,1},
                {1,1,1,0,1,0,1}
            };

            var directionInput = new string[] { "E", "N", "N", "N", "N", "E", "E", "E", "E", "E" };

            string expected = "Finish";

            //act
            string actual = finder.MazeRunner(mapInput, directionInput);

            //assert
            Assert.Equal(expected , actual);
        }

        [Fact]
        public void MazeRunnerDeathTest()
        {
            //arrange
            IPathFinder finder = new ThePathFinder();

            var mapInput = new int[,]
            {
                {1,1,1,1,1,1,1},
                {1,0,0,0,0,0,3},
                {1,0,1,0,1,0,1},
                {0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1},
                {1,0,0,0,0,0,1},
                {1,2,1,0,1,0,1}
            };

            var directionInput = new string[] { "N", "N", "N", "N", "N", "N" };

            string expected = "Dead";

            //act
            string actual = finder.MazeRunner(mapInput, directionInput);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MazeRunnerLostTest()
        {
            //arrange
            IPathFinder finder = new ThePathFinder();

            var mapInput = new int[,]
            {
                {1,1,1,1,1,1,1},
                {1,0,0,0,0,0,3},
                {1,0,1,0,1,0,1},
                {0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1},
                {1,0,0,0,0,0,1},
                {1,2,1,0,1,0,1}
            };

            var directionInput = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E" };

            string expected = "Lost";

            //act
            string actual = finder.MazeRunner(mapInput, directionInput);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}