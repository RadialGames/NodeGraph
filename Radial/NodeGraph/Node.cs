using System.Collections.Generic;

namespace Radial.NodeGraph
{

	public class Node<T>
	{
		// Private member-variables

		public Node()
		{
		}

		public Node(T data) : this(data, null)
		{
		}

		public Node(T data, NodeList<T> neighbors)
		{
			Value = data;
			Neighbors = neighbors;
		}

		public T Value { get; set; }

		protected NodeList<T> Neighbors { get; set; }

		public bool Compare<U>(T x, T y)
		{
			return EqualityComparer<T>.Default.Equals(x, y);
		}
	}
}