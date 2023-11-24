using System;
using System.Collections;
using System.Collections.Generic;

namespace Radial.NodeGraph
{
	// Implemented based on code from https://learn.microsoft.com/en-us/previous-versions/ms379574(v=vs.80)?redirectedfrom=MSDN
	public class Graph<T> : IEnumerable<T>
	{
		public Graph() : this(null)
		{
		}

		public Graph(GraphNodeList<T> nodeSet)
		{
			if (nodeSet == null)
				Nodes = new GraphNodeList<T>();
			else
				Nodes = nodeSet;
		}

		public GraphNodeList<T> Nodes { get; }

		public int Count => Nodes.Count;

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		public void AddNode(GraphNode<T> node)
		{
			// adds a node to the graph
			Nodes.Add(node);
		}

		public void AddNode(T value)
		{
			// adds a node to the graph
			Nodes.Add(new GraphNode<T>(value));
		}

		public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
		{
			from.Neighbors.Add(to);
			from.Costs.Add(cost);
		}

		public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
		{
			from.Neighbors.Add(to);
			from.Costs.Add(cost);

			to.Neighbors.Add(from);
			to.Costs.Add(cost);
		}

		public bool Contains(T value)
		{
			return Nodes.FindByValue(value) != null;
		}

		public bool Remove(T value)
		{
			// first remove the node from the nodeset
			GraphNode<T> nodeToRemove = Nodes.FindByValue(value);
			if (nodeToRemove == null)
				// node wasn't found
				return false;

			// otherwise, the node was found
			Nodes.Remove(nodeToRemove);

			// enumerate through each node in the nodeSet, removing edges to this node
			foreach (GraphNode<T> gnode in Nodes)
			{
				int index = gnode.Neighbors.IndexOf(nodeToRemove);
				if (index != -1)
				{
					// remove the reference to the node and associated cost
					gnode.Neighbors.RemoveAt(index);
					gnode.Costs.RemoveAt(index);
				}
			}

			return true;
		}
	}
}