using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
	public class Grid
	{
		private Object[,] _grid;
		private Object gridContent;

		public Grid (int width, int length, object content)
		{
			gridContent = content;
			_grid = new Object[length, width];
			AddContents(width, length);
		}

		private void AddContents(int width, int length)
		{
			for (int i = 0; i < length; i++) {
				for (int j = 0; j < width; j++)
				_grid [i, j] = gridContent ;
			}
		}

		public Object QueryContents(int x, int y)
		{
			return _grid[x, y];
		}
			
	}

}