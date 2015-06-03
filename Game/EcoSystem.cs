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

		public void PlaceLivingCell (int x, int y)
		{
			cell = grid.QueryContents(x, y);
			cell.Live();
		}

			
		public void Refresh ()
		{
			CheckNeighbouringStatus ();
			UpdateCells();
		}
		
		private void CheckNeighbouringStatus ()
		{
			for (var i = 0; i < grid.gridLength; i++)
				{
					for (var j = 0; j < grid.gridWidth; j++) {

					Cell currentCell = grid.QueryContents (i, j);
					int numberOfLiveNeighbours = CountNeighbours(currentCell, i, j);
					ApplyRules(currentCell, numberOfLiveNeighbours);
				}
			}
		}

		public int CountNeighbours(Cell currentCell, int i, int j)
		{
			int count = 0;

			for (var k = 0; k < grid.gridLength; k++)

			{

				if(k >= (i-1) && k <= (i+1) && k >= 0 && k <= grid.gridLength -1) {

					for (var l = 0; l < grid.gridWidth; l++) {

						if (l >= (j - 1) && l <= (j + 1) && l >= 0 && l <= grid.gridWidth - 1) {
							Cell neighbour = grid.QueryContents(k, l);
							if (neighbour != currentCell && neighbour.isAlive()) {count++;}
						}
					}
				}
			}
			return count;
		}
		
		private void ApplyRules(Cell currentCell, int numberOfLiveNeighbours)
		{
			PopulatedCellsRevive (currentCell, numberOfLiveNeighbours);
			UnderpopulatedCellsDie(currentCell, numberOfLiveNeighbours);
			OverCrowdedCellsDie (currentCell, numberOfLiveNeighbours);
		}

		private void UnderpopulatedCellsDie(Cell currentCell, int numberOfLiveNeighbours)
		{
			if (numberOfLiveNeighbours < 2) { currentCell.KillNextCycle ();}
		}

		private void OverCrowdedCellsDie(Cell currentCell, int numberOfLiveNeighbours)
		{
			if (numberOfLiveNeighbours > 3) { currentCell.KillNextCycle ();}
		}

		private void PopulatedCellsRevive(Cell currentCell, int numberOfLiveNeighbours)
		{
			if (numberOfLiveNeighbours == 3) { currentCell.ReviveNextCycle ();}
		}

		private void UpdateCells()
		{
			for (var i = 0; i < grid.gridLength; i++)
			{
				for (var j = 0; j < grid.gridWidth; j++) {
					Cell currentCell = grid.QueryContents (i, j);
					if(currentCell.IsAliveNextCycle())
					{
						currentCell.Live();
					}
					else
					{
						currentCell.Die();
					}
				}
			}
		}

	}		
}