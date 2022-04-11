using System;

namespace PrivateAssembly{
	
	
	public class Calculator{
		
		
		public  void Additon(int x, int y){
			
			Console.WriteLine("sum is :"+(x+y));
		}
		
		protected void Substraction(int x, int y){
			
			Console.WriteLine("sum is :"+(x-y));
		}
		
		protected internal void Multiplication(int x, int y){
			
			Console.WriteLine("sum is :"+(x*y));
		}
		
	}
}

