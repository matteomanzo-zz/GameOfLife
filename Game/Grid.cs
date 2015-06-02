using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
	public class Grid<T>
	{
		private T[,] _grid;
		private T gridContent;

		public Grid (int width, int length, T content)
		{
			gridContent = content;
			_grid = new T[length, width];
			AddContents(width, length);
		}

		private void AddContents(int width, int length)
		{
			for (int i = 0; i < length; i++) {
				for (int j = 0; j < width; j++)
				_grid [i, j] = gridContent ;
			}
		}

		public T QueryContents(int x, int y)
		{
			return _grid[x, y];
		}
			
	}

}