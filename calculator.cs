class calculator
{
	static void main (string[] args)
	{
		int a = 10;
		int b = 6;
		
		console.WriteLine("Hasil Penambahan : {0} + {1}", a, b, penambahan(a, b));
		console.WriteLine("Hasil Pengurangan : {0} - {1}", a, b, pengurangan(a, b));
		
		
	}
	
	static int penambahan(int a,int b)
	{
		return a + b;
	}
	static int pengurangan(int a,int b)
	{
		return a-b;
	}

}