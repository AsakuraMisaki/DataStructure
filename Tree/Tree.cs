//COMMON TREE (SPECILIZING IN TRANSFORMING TREES/FOREST TO BINARY TREE)
//MISAKI
//180521

using System;

namespace DTTree{

    public class NodeInBinaryTree<T>{

        private T _data;

        private NodeInBinaryTree<T> _lChild, _rChild;

        public T Data{
            get{
                return _data;
            }
        } 

        public NodeInBinaryTree<T> LChild{
            get{
                return _lChild;
            }
        }

        public NodeInBinaryTree<T> RChild{
            get{
                return _rChild;
            }
        }

        public NodeInBinaryTree(T data = default(T), NodeInBinaryTree<T> lChild = null, NodeInBinaryTree<T> rChild = null){
            _data = data;
            _lChild = lChild;
            _rChild = rChild;
        }

    }


    public class MyBinaryTree<T>{

        private NodeInBinaryTree<T> _top;

        public NodeInBinaryTree<T> Top{
            get{
                return _top;
            }
        }

        public MyBinaryTree(NodeInBinaryTree<T> top = null){
            _top = top;
        }

        public int RecursivelyCreate(NodeInBinaryTree<T> newChild, T data = default(T)){
            return 1;
        }

        public void Tz(){
            
            ConsoleKeyInfo x = Console.ReadKey();
            Console.WriteLine(x.Key.ToString());
            Tz();
        }
    }

    public class t{
        static void Main(){
            NodeInBinaryTree<int> topAction = new NodeInBinaryTree<int>();
            MyBinaryTree<int> tree = new MyBinaryTree<int>(topAction);
            tree.Tz();
        }
    }
}
