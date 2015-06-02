using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
	public class Grid<T> where T : class, new()
	{
		private T[,] _grid;
		public int gridLength;
		public int gridWidth;

		public Grid (int width, int length)
		{
			gridLength = length;
			gridWidth = width;
			_grid = new T[length, width];
			AddContents();
		}

		private void AddContents()
		{
			for (int i = 0; i < gridLength; i++) {
				for (int j = 0; j < gridWidth; j++)
					_grid [i, j] = new T();
			}
		}

		public T QueryContents(int x, int y)
		{
			return _grid[x, y];
		}
			
	}

}