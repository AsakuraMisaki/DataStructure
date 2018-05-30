//
//COMMMON CIRCULAR LINEAR QUEUE
//MISAKI
//180428
//

using System;

namespace DTLinearQueue{
	public class MyLinearQueue<T>{
		
		private T[] _data;
		
		private int _maxLength;
		
		private int _front;
		
		private int _rear;
		
		//
		public int Length{

			get{
				
				return ((_maxLength - _front + rear) % _maxLength);

			}
		}

		public MyLinearQueue(int maxLength){

			_maxLength = maxLength;
			
			_data = new T[_maxLength];
			
			_front = 0;
			
			_rear = 0;

			;
		}

		public int CommonAdd(T newrear){
			
			if((_rear + 1) % _maxLength == _front){

				throw new Exception("{-1}");

			}

			_data[(_rear + 1) % _maxLength] = newrear;

			return 1;
		}

		public int CommonDelete(){

			if(_rear == _front){
				
				throw new Exception("{-1}");

			}

			_data[_front] = default(T);

			_front = (_front + 1) % _maxLength;

			return 1;
		}

		public int Clear(){

			for(; Length != 0; Length--){

				CommonDelete();
			}

			return 1;
		
		}

	}

	public class T{
		static int Main(){
			return 1;
		}
	}

}
