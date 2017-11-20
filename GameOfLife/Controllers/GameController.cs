using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameOfLife.Models;

namespace GameOfLife.Controllers
{
    public class Game
    {
        public Cell[,] grid;
        public Game(int gridSize = 8)
        {
            grid = new Cell[gridSize, gridSize];
            SeedGrid();
            SetCoordinates();
            AddNeighbors();
        }

        public Game SeedGrid()
        {
            Random rand = new Random();
            int randInt;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new Cell();
                    randInt = rand.Next(0, 2);
                    if (randInt == 1)
                    {
                        grid[i, j].state = true;
                    }
                }
            }
            return this;
        }

        public Game SetCoordinates()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j].gridX = i;
                    grid[i, j].gridY = j;
                }
            }

            return this;
        }

        public Game AddNeighbors()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    for (int x = i - 1; x <= i + 1; x++)
                    {
                        for (int y = j - 1; y <= j + 1; y++)
                        {
                            if (x >= 0 && x <= grid.GetLength(0) - 1 && y >= 0 && y < grid.GetLength(1) - 1 && (x != i || y != j))
                            {
                                grid[i, j].neighbors.Add(grid[x, y]);
                                //foreach (Cell cell in grid[i, j].neighbors)
                                //{
                                //    Debug.WriteLine(cell.state);
                                //}
                            }
                        }
                    }
                }
            }
            return this;
        }
    }
}