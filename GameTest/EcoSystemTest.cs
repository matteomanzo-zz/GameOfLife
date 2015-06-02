using System;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTest
{
	[TestFixture ()]
	public class EcoSystemTest
	{
		EcoSystem ecosystem;

		[Test ()]
		public void CanCheckCellStatus()
		{
			ecosystem = new EcoSystem(new Grid(3,3, new Cell() ));
			Assert.AreEqual("Dead", ecosystem.CheckCellStatus(1, 1));
		}

		[Test ()]
		public void CanPlaceLivingCells()
		{
			ecosystem = new EcoSystem(new Grid(3,3, new Cell() ));
			ecosystem.PlaceLivingCell(1, 1);
			Assert.AreEqual ("Alive", ecosystem.CheckCellStatus(1, 1));
		}
	}
}

