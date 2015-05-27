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
			
		}

		[Test ()]
		public void ContainsCells()
		{
			grid = new Grid (9);
			Assert.IsInstanceOf<Cell> (grid.Contents(3));
		}
	}
}