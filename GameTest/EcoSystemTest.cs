using System;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTest
{
	[TestFixture()]
	public class EcoSystemTest
	{
		EcoSystem ecosystem;
		Grid<Cell> my_grid;

		[SetUp]
		public void Init ()
		{
			my_grid = new Grid<Cell>(3, 3);
			ecosystem = new EcoSystem(my_grid);


		}

		private string CheckCellStatus(int xcoord, int ycoord)
		{
			Cell this_cell = my_grid.QueryContents(xcoord, ycoord);
			String status = this_cell.isAlive() ? "Alive" : "Dead";
			return status;
		}

		[Test]
		public void CanCheckCellStatus()
		{
			Assert.AreEqual("Dead", CheckCellStatus(1, 1));
		}

		[Test]
		public void CanPlaceLivingCells()
		{
			ecosystem.PlaceLivingCell(1, 1);
			Assert.AreEqual ("Alive", CheckCellStatus(1, 1));
		}

		[Test]
		public void CellsWithFewerThanTwoLiveNeighboursDie()
		{
			ecosystem.PlaceLivingCell(1, 1);
			ecosystem.PlaceLivingCell (1, 0);
			Assert.AreEqual ("Alive", CheckCellStatus(1, 1));
			ecosystem.Refresh ();
			Assert.AreEqual ("Dead", CheckCellStatus(1, 1));
		}

		[Test]
		public void CellsWithMoreThanThreeLiveNeighboursDie()
		{
			ecosystem.PlaceLivingCell(1, 1);
			ecosystem.PlaceLivingCell(0, 1);
			ecosystem.PlaceLivingCell(1, 0);
			ecosystem.PlaceLivingCell (1, 2);
			ecosystem.PlaceLivingCell (0, 2);
			Assert.AreEqual ("Alive", CheckCellStatus(1, 1));
			ecosystem.Refresh ();
			Assert.AreEqual ("Dead", CheckCellStatus(1, 1));
		}

		[Test]
		public void DeadCellsExactlyThreeLiveNeighboursRevive()
		{
			ecosystem.PlaceLivingCell(0, 1);
			ecosystem.PlaceLivingCell(1, 2);
			ecosystem.PlaceLivingCell (1, 0);
			Assert.AreEqual ("Dead", CheckCellStatus(1, 1));
			ecosystem.Refresh ();
			Assert.AreEqual ("Alive", CheckCellStatus(1, 1));
		}
			
	}
}

