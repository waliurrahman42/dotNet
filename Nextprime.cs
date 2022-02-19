
using System;

class NextPrime{
	
	static void Main(string []args){
		
		int num;
		int flag=0;
		
		Console.WriteLine("enter number");
		num=Int32.Parse(Console.ReadLine());
		
		Console.WriteLine($"num={num}");
		
		for(int i=2;i<=num/2;i++){
				if(num%i==0){
					Console.WriteLine("num is not prime");
					flag=1;
					break;
					
				}
		}
		if(flag==0){
			Console.WriteLine(" this is prime number prime number");
			
			for(int i=num+1;;i++){
				int flag2=0;
				
				for(int j=2;j<i/2;j++){
					
					if(i%j==0){
						Console.WriteLine("next prime finding");
						flag2=1;
						break;
					}
				}
				
				
				if(flag2==0){
					Console.WriteLine("next prime nu is"+i);
					break;
				}
			}	
		}	
	}
}
