using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
	public class Grid
	{
		private Cell[,] _grid;

		public Grid (int width, int length)
		{
			_grid = new Cell[length, width];
			AddCells(width, length);
		}

		private void AddCells(int width, int length)
		{
			for (int i = 0; i < length; i++) {
				for (int j = 0; j < width; j++)
				_grid [i, j] = new Cell ();
			}
		}

		public Cell Contents(int x, int y)
		{
			return _grid[x, y];
		}

		public void PlaceLivingCell (int x, int y)
		{
			_grid [x, y] = new Cell (1);
		}
	}

}