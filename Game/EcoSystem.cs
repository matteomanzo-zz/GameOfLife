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
			CheckNeighbouringStatus ();
		}

		private void UnderpopulatedCellsDie(Cell cell, int numberOfLiveNeighbours)
		{
			if (numberOfLiveNeighbours < 2) { cell.Die ();}
		}
		
		private void CheckNeighbouringStatus ()
		{
			for (var i = 0; i < grid.gridLength; i++)
				{
					for (var j = 0; j < grid.gridWidth; j++) {

					Cell cell = grid.QueryContents (i, j);
				int numberOfLiveNeighbours = CountNeighbours(i, j);
				ApplyRules(cell, numberOfLiveNeighbours);
				}
			}
		}
		
	private void ApplyRules(Cell cell, int numberOfLiveNeighbours)
	{
		UnderpopulatedCellsDie(cell, numberOfLiveNeighbours);
	}

			
		//private void PopulatedCellsLive()
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

		private int CountNeighbours(int i, int j)
		{
			int count = 0;

			for (var k = 0; k < grid.gridLength; k++)

			{

				if( k!= i && k >= (i-1) && k <= (i+1) && k > 0 && k < grid.gridLength -1) {

					for (var l = 0; l < grid.gridWidth; l++) {

						if (l!= j && l >= (j - 1) && l <= (j + 1) && l > 0 && l < grid.gridWidth - 1) {
							Cell neighbour = grid.QueryContents(k, l);
							if (neighbour.isAlive()) {count++;}
						}
					}
				}
			}
			return count;

		}

	}
}


