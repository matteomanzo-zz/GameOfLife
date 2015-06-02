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

			
		public void Refresh ()
		{
			UnderpopulatedCellsDie ();
		}

		private void UnderpopulatedCellsDie()
		{
			for (var i = 0; i < grid.gridLength; i++)
			{
				for (var j = 0; j < grid.gridWidth; j++) {
					Cell cell = grid.QueryContents (i, j);
					int count = CountNeighbours(i, j);
					//if count < 3 then cell.Die();
				}
			}
		}

		private int CountNeighbours(xcoord, ycoord)
		{
			int count = 0;

			for (var k = 0; k < grid.gridLength; k++)
				
			{

				if( k >= (i-1) && <= (i+1) && > 0 && < gridLength -1) {
					
				  for (var l = 0; l < grid.gridWidth; l++) {
					
						if (l >= (j-1) && <=(j+1) && > 0 && < gridWidth -1)

					//find neighbour;
					//neighbour = grid.QueryContents();
					//count++ if neighbour.isAlive();
				}
			}

		}
		//private void PopulateCellsLive()
		//		{
		//
		//		}

		//private void OverCrowdedCellsDie()
		//		{
		//
		//		}

		//private void PopulatedCellsRevive()
		//		{
		//
		//		}

	}
}


