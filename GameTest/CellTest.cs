using NUnit.Framework;
using System;

namespace GameOfLife
{
	[TestFixture ()]
	public class CellTest
	{
		Cell cell;
		Cell livecell;

		[SetUp]
		public void Init ()
		{
			cell = new Cell ();
			livecell = new Cell ();
			livecell.Live ();
		}

		[Test ()]
		public void ShouldNotBeAliveByDefault ()
		{
			Assert.IsFalse (cell.isAlive());
		}

		[Test ()]
		public void SomeCellsWillBeAlive ()
		{
			Assert.IsTrue (livecell.isAlive() );
		}

		[Test ()]
		public void AnAliveCellCanDie ()
		{
			livecell.Die ();
			Assert.IsFalse (livecell.isAlive() );
		}

		[Test ()]
		public void ADeadCellCanLive ()
		{
			cell.Live ();
			Assert.IsTrue (cell.isAlive() );
		}

		[Test ()]
		public void DeadCellShouldReturnAnEmptySpace ()
		{
			Assert.AreEqual (cell.DisplaysStatus (), " ");
		}

		[Test ()]
		public void AliveCellShouldReturnAnAsterix ()
		{
			Assert.AreEqual (livecell.DisplaysStatus (), "*");
		}
	}
}

