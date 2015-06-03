using System;
using System.Text;
using GameOfLife;
using System.Threading;

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
			grid = MakeGrid (width, length);
			ecosystem = new EcoSystem(grid);
			ecosystem.PlaceLivingCell (1, 2);
			AnimateGrid ();
		}

		static Grid<Cell> MakeGrid (int length, int width)
		{
			grid = new Grid<Cell> (length, width);
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

		static void AnimateGrid()
		{
			do
			{
				Console.Clear();
				DisplayGrid (grid);
				ecosystem.Refresh();
				Thread.Sleep(250);
			} while (true);
		}

	}
}

