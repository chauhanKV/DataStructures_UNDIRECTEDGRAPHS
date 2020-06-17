using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraphs
{
    class WeightedGraph
    {
        private class Node
        {
            private string value;

            public Node(string value)
            {
                this.Value = value;
            }

            public string Value { get => value; set => this.value = value; }
        }
        private class Edge
        {
            private Node from;
            private Node to;
            private int weight;

            public Edge(Node from, Node to, int weight)
            {
                this.from = from;
                this.to = to;
                this.weight = weight;
            }

            public string stringify()
            {
                return from.Value + "->" + to.Value;
            }
        }

        private Node node;
        Dictionary<string, Node> nodes = new Dictionary<string, Node>();
        Dictionary<Node, List<Edge>> nodeEdges = new Dictionary<Node, List<Edge>>();

        public void addNode(string value)
        {
            node = new Node(value);
            nodes.Add(value, node);

            nodeEdges.Add(node, new List<Edge>());
        }

        public void addEdge(string from, string to, int weight)
        {
            var fromNode = new Node("");
            var toNode = new Node("");

            if (nodes.ContainsKey(from))
                fromNode = nodes[from];

            if (nodes.ContainsKey(to))
                toNode = nodes[to];

            if (nodes.ContainsKey(from) && nodes.ContainsKey(to))
            {
                nodeEdges[fromNode].Add(new Edge(fromNode, toNode, weight));
                nodeEdges[fromNode].Add(new Edge(toNode, fromNode, weight));
            }
        }

        public void print()
        {
            foreach (KeyValuePair<Node, List<Edge>> keyValuePair in nodeEdges)
            {

                StringBuilder str = new StringBuilder();
                str.Append(keyValuePair.Key.Value + " is connected as : ");
                foreach (var edge in keyValuePair.Value)
                {
                    str.Append("[" + edge.stringify() + "]");
                   
                }
                Console.WriteLine(str.ToString());
            }
        }

    }
}
