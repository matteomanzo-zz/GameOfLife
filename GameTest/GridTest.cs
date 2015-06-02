using NUnit.Framework;
using System;

namespace GameOfLife
{
	[TestFixture ()]
	public class GridTest
	{
		Grid<Cell> grid;

		[SetUp]
		public void Init ()
		{
			grid = new Grid<Cell> (3, 3);	
		}

		[Test ()]
		public void ContainsCells()
		{
			Assert.IsInstanceOf<Cell> (grid.QueryContents(1, 2));
		}
			
	}
}