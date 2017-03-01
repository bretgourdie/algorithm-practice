using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Common
{
    public class Graph<T> : IEnumerable<T>
    {
        private NodeList<T> nodeSet;

        public Graph() : this(null) { }
        public Graph(NodeList<T> nodeSet)
        {
            if (nodeSet == null)
            {
                this.nodeSet = new NodeList<T>();
            }
            else
            {
                this.nodeSet = nodeSet;
            }
        }

        public void AddNode(GraphNode<T> node)
        {
            nodeSet.Add(node);
        }

        public void AddNode(T value)
        {
            var node = new GraphNode<T>(value);
            this.AddNode(node);
        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, int cost)
        {
            this.AddDirectedEdge(from, to, cost);
            this.AddDirectedEdge(to, from, cost);
        }

        public bool Contains(T value)
        {
            var node = nodeSet.FindByValue(value);

            var found = node != null;

            return found;
        }

        public bool Remove(T value)
        {
            var nodeToRemove = (GraphNode<T>)nodeSet.FindByValue(value);

            if (nodeToRemove == null)
            {
                return false;
            }

            nodeSet.Remove(nodeToRemove);

            foreach (GraphNode<T> node in nodeSet)
            {
                var index = node.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                {
                    node.Neighbors.RemoveAt(index);
                    node.Costs.RemoveAt(index);
                }
            }

            return true;
        }

        public NodeList<T> Nodes
        {
            get
            {
                return nodeSet;
            }
        }

        public int Count
        {
            get
            {
                return nodeSet.Count;
            }
        }
    }
}
