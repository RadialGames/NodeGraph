using System.Collections.Generic;

namespace Radial.NodeGraph
{

	public class GraphNode<T> : Node<T>
	{
		private List<int> costs;

		public GraphNode()
		{
		}

		public GraphNode(T value) : base(value)
		{
		}

		public GraphNode(T value, NodeList<T> neighbors) : base(value, neighbors)
		{
		}

		public new NodeList<T> Neighbors
		{
			get
			{
				if (base.Neighbors == null) base.Neighbors = new NodeList<T>();
				return base.Neighbors;
			}
		}

		public List<int> Costs
		{
			get
			{
				if (costs == null) costs = new List<int>();
				return costs;
			}
		}
	}
}