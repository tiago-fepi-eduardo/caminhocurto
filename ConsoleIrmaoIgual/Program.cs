using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleCaminhoCurto
{
    class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("#######");

            // 9 is the number the search have to find. 1 is the number where the truck can cross. 0 is a bad road that can't be crossed.
			int[,] ar = { { 1, 0, 0, 0 }, { 1, 0 ,0 ,0 }, { 1, 0,0 ,0 }, { 1, 0, 0, 0 }, { 1, 1, 9, 0 } };

			var result = minimumDistance(5, 4, ar);

			Console.Read(); //Pause
		}


		// METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
		public static int minimumDistance(int numRows, int numColumns, int[,] area)
		{
			int distance = 0;

			for (int x = 0; x < numRows; x++)
			{

				for (int y = 0; y < numColumns; y++)
				{
					int xValue = area[x, y];
					if (xValue == 9)
					{
						return distance;
					}
					else if (xValue == 1)
						{
							distance = distance + 1;
						}
				}
			}
			return distance;
		}

	}
}
