using NUnit.Framework;
using System;

namespace GameOfLife
{
	[TestFixture ()]
	public class CellTest
	{
		Cell cell;

		[SetUp]
		public void Init ()
		{
			cell = new Cell ();
		}

		[Test ()]
		public void ShouldNotBeAliveByDefault ()
		{
			Assert.IsFalse (cell.isAlive());
		}

//		[Test ()]
//		public void ShouldShowAnAsterixIconIfAlive ()
//		{
//			Assert.IsTrue (aliveCell.isAlive() );
//		}
	}
}

