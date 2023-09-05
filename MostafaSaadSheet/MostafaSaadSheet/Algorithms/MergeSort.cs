using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaSaadSheet.Algorithms
{
	internal class MergeSort
	{
		public static void Sort(int[] arr)
		{
			int[] aux = new int[arr.Length];
			Sort(arr, aux, 0, arr.Length - 1);
		}

		private static void Sort(int[] arr, int[] aux, int lo, int hi)
		{
			if (lo == hi) return;

			int mid = lo + (hi - lo) / 2;

			Sort(arr, aux, lo, mid);
			Sort(arr, aux, mid + 1, hi);
			Merge(arr, aux, lo, mid, hi);
		}

		private static void Merge(int[] arr, int[] aux, int lo, int mid, int hi)
		{
			for (int i = lo; i <= hi; i++)
				aux[i] = arr[i];

			int l = lo;
			int r = mid + 1;
			for (int i = lo; i <= hi; i++)
			{
				if (l > mid)
					arr[i] = aux[r++];
				else if (r > hi)
					arr[i] = aux[l++];

				else if (aux[l] < aux[r])
					arr[i] = aux[l++];
				else
					arr[i] = aux[r++];
			}
		}

	}

}
