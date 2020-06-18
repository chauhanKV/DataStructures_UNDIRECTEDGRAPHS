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

            //---------------------------//

            Console.WriteLine("-------- OOPs approach for WeightedGraph ---------");

            WeightedGraphOOP weightedGraphOOP = new WeightedGraphOOP();
            weightedGraphOOP.addNode("A");
            weightedGraphOOP.addNode("B");
            weightedGraphOOP.addNode("C");
            weightedGraphOOP.addNode("D");

            weightedGraphOOP.addEdge("A", "B", 2);
            weightedGraphOOP.addEdge("B", "D", 5);
            weightedGraphOOP.addEdge("D", "C", 10);

            weightedGraphOOP.print();


            Console.ReadLine();
        }
    }
}
