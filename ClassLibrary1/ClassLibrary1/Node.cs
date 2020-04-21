using System;
using System.Collections.Generic;

namespace BussRout
{
    public class Node
    {
        public string Name { get; set; }
        public List<string> start;
        public List<Connections> Connections;
        private Random randomWeight = new Random();
        public Node(string name)
        {
            Name = name;
            Connections = new List<Connections>();
            start = new List<string>();
            start.Add(name);
        }
        public void AddConnections(Node a, Node b)
        {
            int weight = GenerateRandomWeight();
            Connections.Add(new Connections(a, b, weight));
        }
        public List<Connections> getConnections()
        {
            return Connections;
        }
        private int GenerateRandomWeight()
        {
            return randomWeight.Next(1, 10);
        }
    }
}
