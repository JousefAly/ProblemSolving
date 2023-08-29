namespace MostafaSaadSheet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int row = 0;
			int col = 0;
			for (int i = 1; i <= 5; i++)
			{
				int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				for (int j = 1; j <= 5; j++)
				{
					if (line[j - 1] == 1)
					{
						row = i;
						col = j;
						break;
					}
				}
			}
			int result = Math.Abs(3 - row) + Math.Abs(3 - col);
            Console.WriteLine(result);
        }

	}
}