using System.Collections.ObjectModel;

namespace Radial.NodeGraph
{
	public class GraphNodeList<T> : Collection<GraphNode<T>>
	{
		public GraphNodeList()
		{
		}

		public GraphNodeList(int initialSize)
		{
			// Add the specified number of items
			for (var i = 0; i < initialSize; i++) Items.Add(default);
		}

		public GraphNode<T> FindByValue(T value)
		{
			// search the list for the value
			foreach (GraphNode<T> node in Items)
				if (node.Value.Equals(value))
					return node;

			// if we reached here, we didn't find a matching node
			return null;
		}
	}
}