using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
	public class Grid<T> where T : class, new()
	{
		private T[,] _grid;

		public Grid (int width, int length)
		{
			_grid = new T[length, width];
			AddContents(width, length);
		}

		private void AddContents(int width, int length)
		{
			for (int i = 0; i < length; i++) {
				for (int j = 0; j < width; j++)
					_grid [i, j] = new T();
			}
		}

		public T QueryContents(int x, int y)
		{
			return _grid[x, y];
		}
			
	}

}