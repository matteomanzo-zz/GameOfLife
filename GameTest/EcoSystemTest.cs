using System;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTest
{
	[TestFixture ()]
	public class EcoSystemTest
	{
		EcoSystem ecosystem;

		[SetUp]
		public void Init ()
		{
			ecosystem = new EcoSystem(new Grid<Cell>(3,3));
		}

		[Test ()]
		public void CanCheckCellStatus()
		{
			Assert.AreEqual("Dead", ecosystem.CheckCellStatus(1, 1));
		}

		[Test ()]
		public void CanPlaceLivingCells()
		{
			ecosystem.PlaceLivingCell(1, 1);
			Assert.AreEqual ("Alive", ecosystem.CheckCellStatus(1, 1));
		}

		[Test ()]
		public void CellsWithFewerThanTwoLiveNeighboursDie()
		{
			ecosystem.PlaceLivingCell(1, 1);
			ecosystem.PlaceLivingCell (1, 0);
			Assert.AreEqual ("Alive", ecosystem.CheckCellStatus(1, 1));
			ecosystem.Refresh ();
			Assert.AreEqual ("Dead", ecosystem.CheckCellStatus(1, 1));
		}
	}

}

