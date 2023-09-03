using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaSaadSheet
{
	public static class CGlobal
	{
		public static int[] ReadIntArray()
		{
			return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		}
	}
}
