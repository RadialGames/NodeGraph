using System.Collections.ObjectModel;

namespace Radial.NodeGraph
{
	public class NodeList<T> : Collection<Node<T>>
	{
		public NodeList()
		{
		}

		public NodeList(int initialSize)
		{
			// Add the specified number of items
			for (var i = 0; i < initialSize; i++) Items.Add(default);
		}

		public Node<T> FindByValue(T value)
		{
			// search the list for the value
			foreach (Node<T> node in Items)
				if (node.Value.Equals(value))
					return node;

			// if we reached here, we didn't find a matching node
			return null;
		}
	}
}