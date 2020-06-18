using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraphs
{
    class WeightedGraphOOP
    {
        private class Node
        {
            private string value;
            private List<Edge> edges = new List<Edge>();

            public Node(string value)
            {
                this.Value = value;
            }

            public string Value { get => value; set => this.value = value; }

            public void addEdges(Node to, int weight)
            {
                edges.Add(new Edge(this, to, weight));
            }

            public List<Edge> getEdges()
            {
                return edges;
            }
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

        public void addNode(string value)
        {
            nodes.Add(value, new Node(value));
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
                fromNode.addEdges(toNode, weight);
                toNode.addEdges(fromNode, weight);
            }
        }

        public void print()
        {
            foreach (KeyValuePair<string, Node> keyValuePair in nodes)
            {

                StringBuilder str = new StringBuilder();
                str.Append(keyValuePair.Key + " is connected as : ");
                foreach (var edges in keyValuePair.Value.getEdges())
                {
                    str.Append("[" + edges.stringify() + "]");

                }
                Console.WriteLine(str.ToString());
            }
        }
    }
}
