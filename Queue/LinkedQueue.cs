//
//COMMON CIRCULAR LINKED QUEUE
//MISAKI
//180428
//

using System;

namespace DTLinkedQueue{

	public class Node<T>{

		private T _data;

		private Node<T> _next;

		public T Data{

			get{
				return _data;

			}
		}

		public Node<T> Next{

			get{

				return _next;

			}

		}

		public Node(T data = default(T), Node<T> next = null){

			_data = data;

			_next = next;

		}

	}

	
	public class MyLinkedQueue<T>{

		private Node<T> _front;

		private Node<T> _rear;

		public int Length{

			get{

				return 1;

			}

		}

		public MyLinkedQueue(){

			_front = new Node<T>();
			
			_rear = _front;

		}

		public int CommonAdd(){

			Node<T> newrear = new Node<T>();

			_rear._next = newrear;

			_rear = newrear;
			
			_rear._next = _front;
			
		}

		public int CommonDelete(){

			Node<T> DestoryOne = _front._next;

			_front._next = DestoryOne._next;

			DestoryOne = default(Node<T>);

		}


	
	}

}
