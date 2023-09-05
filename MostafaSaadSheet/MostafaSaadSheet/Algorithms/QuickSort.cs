using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaSaadSheet.Algorithms
{
	internal class QuickSort
	{
		public static void Shuffle(int[] array)
		{
			var random = new Random();
			int n = array.Length;
			for (int i = n - 1; i > 0; i--)
			{
				int j = random.Next(0, i + 1);
				int temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}

		public static void Sort(int[] arr)
		{
			Shuffle(arr);
			Sort(arr, 0 , arr.Length - 1);
		}
		public static int Partition(int[] arr, int lo, int hi)
		{
			int i = lo + 1;
			int j = hi;

			while (true)
			{
				while (arr[i] <= arr[lo])
					if (i++ == hi)
						break;


				while (arr[j] >= arr[lo])
					if (j-- == lo)
						break;

				if (i >= j)
					break;

				Swap(arr, i, j);
			}

			Swap(arr, lo, j);
			return j;

		}

		private static void Sort(int[] arr, int lo, int hi)
		{
			if (hi <= lo) return;

			int j = Partition(arr, lo, hi);
			Sort(arr, lo, j - 1);
			Sort(arr, j + 1, hi);
		}

		private static void Swap(int[] arr, int p1, int p2)
		{
			int temp = arr[p1];
			arr[p1] = arr[p2];
			arr[p2] = temp;
		}
	}
}
