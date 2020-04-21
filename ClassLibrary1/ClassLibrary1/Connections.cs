using System;
using System.Collections.Generic;
using System.Text;

namespace BussRout
{
    public class Connections
    {
        public Node a;
        public Node b;
        public int Weight { get; private set; }
        public Connections(Node connect, Node toConnectTo, int lengthBetweenNodes)
        {
            a = connect;
            b = toConnectTo;
            Weight = lengthBetweenNodes;
        }
    }
}
