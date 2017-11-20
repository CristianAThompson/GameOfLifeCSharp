using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOfLife.Models
{
    public class Cell
    {
        private int foo;
        public int? gridX = null;
        public int? gridY = null;
        public bool state = false;
        public List<Cell> neighbors = new List<Cell>();

        public int GetFoo()
        {
            return foo;
        }

        public void SetFoo(int value)
        {
            foo = value;
        }

        static void Main()
        {
            Cell cell = new Cell();
            cell.SetFoo(5150);
            Console.WriteLine("TRACER: " + cell.GetFoo());
        }
    }
}