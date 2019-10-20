using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD
{
    class Node
    {
        //ATRIBUTOS
        private int item;
        private Node right;
        private Node left;
        //GETTERS Y SETTERS
        public int Item { get => item; set => item= value; }
        internal Node Right { get => right; set => right = value; }
        internal Node Left { get => left; set => left = value; }
        //CONSTRUCTOR
        public Node() {

        }
        
    }
}
