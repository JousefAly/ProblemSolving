using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostafaSaadSheet.Algorithms
{
	internal class FixedCapacityStackOfType<T>
	{
		private T[] S;
		private int Size = 0;
		public FixedCapacityStackOfType(int capacity)
		{
			S = new T[capacity];
		}

		public void push(T s)
		{
			S[Size] = s;
			Size++;
		}
		public T Pop()
		{
			Size--;
			return S[Size];
		}
	}
}
