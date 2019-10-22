using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD
{
    class Tree
    {
        public Node root;
        private String inorder;
        private String preorder;
        private String postorder;
        private bool empty = true; //Define si un item está repetido o no
        public Tree()
        {//Inicializa la raíz como nula
            root = null;
        }
        //GETTERS Y SETTERS
        public String InOrder { get => inorder; set => inorder = value; }
        public String PreOrder { get => preorder; set => preorder = value; }
        public String PostOrder { get => postorder; set => postorder = value; }
        public bool Empty { get => empty; set => empty = value; }
        //MÉTODOS
        public Node ReturnRoot()
        {//Retorna la raíz
            return root;
        }
        public void ClearList() {//Limpio los listados
            inorder = "";
            preorder = "";
            postorder = "";
        }
        public void Insert(int id)
        {//Insertar items
            Node newNode = new Node();
            newNode.Item = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.Item)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Preorder(Node Root)
        {//Mostrar árbol en Preorder
            if (Root != null)
            {
                preorder += Root.Item + " - ";
                Preorder(Root.Left);
                Preorder(Root.Right);
            }
        }
        public void Inorder(Node Root)
        {//Mostrar árbol en Inorder
            if (Root != null)
            {
                Inorder(Root.Left);
                inorder += Root.Item + " - ";
                Inorder(Root.Right);
            }
        }
        public void Postorder(Node Root)
        {//Mostar árbol en PostOrder
            if (Root != null)
            {
                Postorder(Root.Left);
                Postorder(Root.Right);
                postorder += Root.Item + " - ";
            }
        }
        public void FindItem(Node Root, int Item)
        {//Si existe el item retorno true
            if (Root != null)
            {
                FindItem(Root.Left, Item);
                FindItem(Root.Right, Item);
                if (Root.Item == Item)
                {
                    empty = false;
                }
            }
        }

    }
}
