using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class NodeAlgoritmos
    {

        public int Data;
        public NodeAlgoritmos Left, Right;

        public NodeAlgoritmos(int data)
        {
            Data = data;
            Left = Right = null;
        }

    }
}
