using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
	public class Grid
	{
		private Cell[] _grid;

		public Grid (int numberOfCells)
		{
			_grid = new Cell[numberOfCells];
			AddCells();
		}

		private void AddCells()
		{
			for (int i = 0; i < _grid.Length; i++) {
				_grid [i] = new Cell ();
			}
		}

		public Object Contents(int index)
		{
			return _grid[index];
		}

	}

}