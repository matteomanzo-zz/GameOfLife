using System;
using GameOfLife;

namespace GameOfLife
{
	public class EcoSystem
	{
		Grid<Cell> grid;
		Cell cell;

		public EcoSystem (Grid<Cell> a_grid)
		{
			grid = a_grid;
		}

		public string CheckCellStatus(int xcoord, int ycoord)
		{
			cell = grid.QueryContents(xcoord, ycoord);
			String status = cell.isAlive() ? "Alive" : "Dead";
			return status;
		}

		public void PlaceLivingCell (int x, int y)
		{
			cell = grid.QueryContents(x, y);
			cell.Live();
		}

			
	}
}


