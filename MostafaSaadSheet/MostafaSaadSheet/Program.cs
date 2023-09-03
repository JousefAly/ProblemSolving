namespace MostafaSaadSheet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", arr));
        }

	}
}