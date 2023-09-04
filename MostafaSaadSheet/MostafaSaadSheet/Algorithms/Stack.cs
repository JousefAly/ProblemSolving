namespace MostafaSaadSheet.Algorithms
{
	internal class LinkedList
	{
		private class Node
		{
			public string Item;
			public Node Next;
		}

		private Node first = null;

		public string Pop()
		{
			string item = first.Item;
			first = first.Next;
			return item;
		}
		public void Push(string item)
		{
			var newNode = new Node { Item = item };
			newNode.Next = first;

		}
	}
}
