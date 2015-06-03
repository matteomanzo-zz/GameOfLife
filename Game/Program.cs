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
			width = 17;
			length = 17;
			grid = MakeGrid (width, length);
			ecosystem = new EcoSystem(grid);
			PlaceCells ();
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

		static void PlaceCells ()
		{
			ecosystem.PlaceLivingCell (2, 4);
			ecosystem.PlaceLivingCell (2, 5);
			ecosystem.PlaceLivingCell (2, 6);
			ecosystem.PlaceLivingCell (2, 10);
			ecosystem.PlaceLivingCell (2, 11);
			ecosystem.PlaceLivingCell (2, 12);
			ecosystem.PlaceLivingCell (4, 2);
			ecosystem.PlaceLivingCell (4, 7);
			ecosystem.PlaceLivingCell (4, 9);
			ecosystem.PlaceLivingCell (4, 14);
			ecosystem.PlaceLivingCell (5, 2);
			ecosystem.PlaceLivingCell (5, 7);
			ecosystem.PlaceLivingCell (5, 9);
			ecosystem.PlaceLivingCell (5, 14);
			ecosystem.PlaceLivingCell (6, 2);
			ecosystem.PlaceLivingCell (6, 7);
			ecosystem.PlaceLivingCell (6, 9);
			ecosystem.PlaceLivingCell (6, 14);
			ecosystem.PlaceLivingCell (7, 4);
			ecosystem.PlaceLivingCell (7, 5);
			ecosystem.PlaceLivingCell (7, 6);
			ecosystem.PlaceLivingCell (7, 10);
			ecosystem.PlaceLivingCell (7, 11);
			ecosystem.PlaceLivingCell (7, 12);
			ecosystem.PlaceLivingCell (8, 8);
			ecosystem.PlaceLivingCell (8, 9);
			ecosystem.PlaceLivingCell (8, 10);
			ecosystem.PlaceLivingCell (9, 4);
			ecosystem.PlaceLivingCell (9, 5);
			ecosystem.PlaceLivingCell (9, 6);
			ecosystem.PlaceLivingCell (9, 10);
			ecosystem.PlaceLivingCell (9, 11);
			ecosystem.PlaceLivingCell (9, 12);
			ecosystem.PlaceLivingCell (10, 2);
			ecosystem.PlaceLivingCell (10, 7);
			ecosystem.PlaceLivingCell (10, 9);
			ecosystem.PlaceLivingCell (10, 14);
			ecosystem.PlaceLivingCell (11, 2);
			ecosystem.PlaceLivingCell (11, 7);
			ecosystem.PlaceLivingCell (11, 9);
			ecosystem.PlaceLivingCell (11, 14);
			ecosystem.PlaceLivingCell (12, 2);
			ecosystem.PlaceLivingCell (12, 7);
			ecosystem.PlaceLivingCell (12, 9);
			ecosystem.PlaceLivingCell (12, 14);
			ecosystem.PlaceLivingCell (14, 4);
			ecosystem.PlaceLivingCell (14, 5);
			ecosystem.PlaceLivingCell (14, 6);
			ecosystem.PlaceLivingCell (14, 10);
			ecosystem.PlaceLivingCell (14, 11);
			ecosystem.PlaceLivingCell (14, 12);
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

