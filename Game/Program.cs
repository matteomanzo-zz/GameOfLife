using System;
using System.Text;
using GameOfLife;

namespace GameOfLife
{
	public class Program
	{
		static int width;
		static int length;
		static Grid<Cell> grid;
		static EcoSystem ecosystem;

		static void Main (string[] args)
		{
			width = 3;
			length = 3;
			grid = MakeGrid (width, length, new Cell());
			ecosystem = new EcoSystem(grid);
			DisplayGrid (grid);
		}

		static Grid<Cell> MakeGrid (int length, int width, Cell cell)
		{
			grid = new Grid<Cell> (length, width, cell);
			return grid;
		}

		static void DisplayGrid(Grid<Cell> grid)
		{
			for (var i = 0; i < length; i++)
			{
				StringBuilder row = new StringBuilder();
				for (var j = 0; j < width; j++) {
					Cell cell = grid.QueryContents (i, j);
					row.Append (cell.DisplaysStatus());
				}
				Console.WriteLine(row);
			}
		}

//		public void AnimateGrid()
//		{
//		}

	}
}

