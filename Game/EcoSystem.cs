using System;
using GameOfLife;

namespace GameOfLife
{
	public class EcoSystem
	{
		Grid grid;
		Cell cell;

		public EcoSystem (Grid a_grid)
		{
			grid = a_grid;
		}

		public string CheckCellStatus(int xcoord, int ycoord)
		{
			cell = (Cell)grid.QueryContents(xcoord, ycoord);
			String status = cell.isAlive() ? "Alive" : "Dead";
			return status;
		}

		public void PlaceLivingCell (int x, int y)
		{
			cell = (Cell)grid.QueryContents(x, y);
			cell.Live();
		}
	}
}

