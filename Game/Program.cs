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
			grid = MakeGrid (3, 3);
			ecosystem = new EcoSystem(grid);
		}

		static Grid MakeGrid (int length, int width)
		{
			Grid grid = new Grid (length, width);
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

