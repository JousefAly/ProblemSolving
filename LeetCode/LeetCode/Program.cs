
using System;
using System.Linq;

namespace LeetCode
{
	class Program
	{
		static void Main(string[] args)
		{
							
				var firstLine = Console.ReadLine();

				//int n = firstLine[0];
				int h = firstLine[2];

				var secondLine = Console.ReadLine().Split(' ');
				var heights = secondLine.Select(x => int.Parse(x)).ToArray();

				Console.WriteLine(GetMaxWidth(h, heights));
			

		}
		public static int GetMaxWidth(int h, int[] freindsHeights)
		{
			int totalWidth = 0;
			foreach (var height in freindsHeights)
			{
				if (height <= h)
					totalWidth++;
				else
					totalWidth += 2;
			}
			return totalWidth;
		}

	}
}
