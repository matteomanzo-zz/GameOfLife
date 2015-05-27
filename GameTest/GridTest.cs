using NUnit.Framework;
using System;

namespace GameOfLife
{
	[TestFixture ()]
	public class GridTest
	{
		Grid grid;

		[SetUp]
		public void Init ()
		{
		    grid = new Grid (9);	
		}

		[Test ()]
		public void ContainsCells()
		{
			Assert.IsInstanceOf<Cell> (grid.Contents(3));
		}

		[Test ()]
		public void CanPlaceLivingCells()
		{
			grid.PlaceLivingCell(5);
			Cell cell = grid.Contents(5);
			Assert.IsTrue (cell.isAlive ());
		}
	}
}