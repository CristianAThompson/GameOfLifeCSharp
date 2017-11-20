using System;
using GameOfLife.Controllers;
using GameOfLife.Models;
using NUnit.Framework;

[TestFixture]
public class CellTest
{
    [Test]
    public void FooSet()
    {
        Cell cell = new Cell();
        cell.SetFoo(5150);
        Assert.AreEqual(5150, cell.GetFoo());
    }

    [Test]
    public void CheckInitialGrid()
    {
        Game game = new Game();
        Assert.AreEqual(64, game.grid.Length);
    }

    [Test]
    public void CellHasXandY()
    {
        Game game = new Game();
        for (int i = 0; i < game.grid.GetLength(0); i++)
        {
            for (int j = 0; j < game.grid.GetLength(1); j++)
            {
                Assert.IsNotNull(game.grid[i, j].gridX);
                Assert.IsNotNull(game.grid[i, j].gridY);
            }
        }
    }

    [Test]
    public void AfterSeedSomeAreAlive()
    {
        Game game = new Game();
        bool someAreAlive = false;
        for (int i = 0; i < game.grid.GetLength(0); i++)
        {
            for (int j = 0; j < game.grid.GetLength(1); j++)
            {
                if (game.grid[i, j].state)
                {
                    someAreAlive = true;
                }
            }
        }
        Assert.AreEqual(true, someAreAlive);
    }

    [Test]
    public void TestNeighborsAddedWithCorrectCoordinates()
    {
        Game game = new Game();
        Assert.Contains(game.grid[0, 1], game.grid[1, 2].neighbors);
        Assert.Contains(game.grid[0, 2], game.grid[1, 2].neighbors);
        Assert.Contains(game.grid[0, 3], game.grid[1, 2].neighbors);
        Assert.Contains(game.grid[1, 1], game.grid[1, 2].neighbors);
        Assert.Contains(game.grid[1, 3], game.grid[1, 2].neighbors);
        Assert.Contains(game.grid[2, 1], game.grid[1, 2].neighbors);
        Assert.Contains(game.grid[2, 2], game.grid[1, 2].neighbors);
        Assert.Contains(game.grid[2, 3], game.grid[1, 2].neighbors);
    }
}

