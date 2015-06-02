using System;
using GameOfLife;

namespace GameOfLife
{
	public class Program
	{
		static Grid grid;
		static EcoSystem ecosystem;

		static void Main (string[] args)
		{
			grid = MakeGrid (3, 3, new Cell());
			ecosystem = new EcoSystem(grid);
		}

		static Grid MakeGrid (int length, int width, object contents)
		{
			Grid grid = new Grid (length, width, contents);
			return grid;
		}
//
//		public void DisplayGrid()
//		{
//		}
//
//		public void AnimateGrid()
//		{
//		}

	}
}

