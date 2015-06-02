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
			Cell cell = grid.Contents(xcoord, ycoord);
			String status = cell.isAlive() ? "Alive" : "Dead";
			return status;
		}
	}
}

