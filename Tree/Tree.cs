//COMMON TREE (SPECILIZING IN TRANSFORMING TREES/FOREST TO BINARY TREE)
//MISAKI
//180521

using System;

namespace DTTree{

    public class NodeInBinaryTree<T>{

        private T _data;

		public char charRef;

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

		private int _length;

		public int Length{
			get{
				return _length;
			}
		}

        public NodeInBinaryTree<T> Top{
            get{
                return _top;
            }
        }

        public MyBinaryTree(NodeInBinaryTree<T> top = null, int length = 0){
            _top = top;
			_length = length;
        }

		public int RecursivelyCreate(NodeInBinaryTree<T> newChild = null, T data = default(T), int length = 0){
			string RefNodes = Console.ReadLine();
			char[] Nodes = RefNodes.ToCharArray();
			for(int position = 0; position < Nodes.Length; position++){
				if(Nodes[position] != '#'){
					newChild = new NodeInBinaryTree<T>();

				}
				else{
					newChild = null;
				}
			}
			return 1;
		}

        public int RecursivelyCreate(NodeInBinaryTree<T> newChild, T data = default(T)){
			ConsoleKeyInfo item = Console.ReadKey();
			if(item.KeyChar != '#'){
				newChild = new NodeInBinaryTree<T>();
				Console.Write(newChild.charRef);
				RecursivelyCreate(newChild.LChild, default(T));
				RecursivelyCreate(newChild.RChild, default(T));
			}
			else{
				newChild = null;
				return -1;
			}
            return 1;
        }

        public void Tz(){
            
            ConsoleKeyInfo x = Console.ReadKey();
			if(x.Key.ToString() == "#"){
				return;
			}
            Console.WriteLine(x.KeyChar);
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