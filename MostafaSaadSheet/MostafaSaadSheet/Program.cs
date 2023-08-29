namespace MostafaSaadSheet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			int totalProblems = 0;
			for (int i = 0; i < n; i++)
			{
				string[] inputLine = Console.ReadLine().Split(' ');
				if(inputLine.Select(int.Parse).Sum() >= 2)
					totalProblems++;

			}

            Console.WriteLine(totalProblems);
        }

	}
}