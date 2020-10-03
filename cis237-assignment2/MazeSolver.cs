﻿using System;
using System.Data;

namespace cis237_assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        private bool found = false;

        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            // Do work needed to use mazeTraversal recursive call and solve the maze.
            maze[xStart, yStart] = char.Parse("X");
            MazeTraversal(maze, xStart, yStart);
        }

        // Outside Reference: https://stackoverflow.com/questions/2044591/what-is-the-difference-between-array-getlength-and-array-length#:~:text=GetLength(0)%20method%20returns%20number,direction%20in%20a%20multidimensional%20array.
        private void PrintMaze(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int t = 0; t < maze.GetLength(1); t++)
                {
                    Console.Write(maze[i, t] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// More than likely you will need to pass in at a minimum the current position
        /// in X and Y maze coordinates. EX: mazeTraversal(int currentX, int currentY)
        /// </summary>
        // Outside Reference: https://www.cs.bu.edu/teaching/alg/maze/
        // Outside Reference: https://stackoverflow.com/questions/22747109/avoid-out-of-bounds-exception-in-2d-array
        private void MazeTraversal(char[,] maze, int xStart, int yStart)
        {
            maze[xStart, yStart] = char.Parse("X");
            // Implement maze traversal recursive call
            if (xStart == maze.GetLength(0) - 1 || yStart == maze.GetLength(1) - 1)
            {
                maze[xStart, yStart] = char.Parse("X");
                PrintMaze(maze);
                Console.WriteLine("Finished!");
                found = true;
            }
            if (found == false && maze[(xStart - 1), yStart] == '.')
            {
                maze[xStart, yStart] = char.Parse("X");
                PrintMaze(maze);
                MazeTraversal(maze, xStart - 1, yStart);
            }
            if (found == false && maze[(xStart + 1), yStart] == '.')
            {
                maze[xStart, yStart] = char.Parse("X");
                PrintMaze(maze);
                MazeTraversal(maze, xStart + 1, yStart);
            }
            if (found == false && maze[xStart, (yStart - 1)] == '.')
            {
                maze[xStart, yStart] = char.Parse("X");
                PrintMaze(maze);
                MazeTraversal(maze, xStart, yStart - 1);
            }
            if (found == false && maze[xStart, (yStart + 1)] == '.')
            {
                maze[xStart, yStart] = char.Parse("X");
                PrintMaze(maze);
                MazeTraversal(maze, xStart, yStart + 1);
            }
            if (found == false && maze[(xStart - 1), yStart] != '.' &&
                    maze[xStart, (yStart - 1)] != '.' &&
                    maze[(xStart + 1), yStart] != '.' &&
                    maze[xStart, (yStart + 1)] != '.')
            {
                maze[xStart, yStart] = char.Parse("O");
                PrintMaze(maze);
            }
        }
    }
}
