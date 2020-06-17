using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightedGraph weightedGraph = new WeightedGraph();
            weightedGraph.addNode("A");
            weightedGraph.addNode("B");
            weightedGraph.addNode("C");
            weightedGraph.addNode("D");

            weightedGraph.addEdge("A", "B", 2);
            weightedGraph.addEdge("B", "D", 5);
            weightedGraph.addEdge("D", "C", 10);

            weightedGraph.print();
            Console.ReadLine();
        }
    }
}
