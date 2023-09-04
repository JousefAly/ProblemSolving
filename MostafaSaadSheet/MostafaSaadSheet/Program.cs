using MostafaSaadSheet.Algorithms;

namespace MostafaSaadSheet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 3, 4, 5, 90, 2500, 0, 1, 2, 100, 140, 180 };			

			MergeSort.Sort(arr);
			Console.WriteLine(string.Join(',', arr));
		}

	}
}