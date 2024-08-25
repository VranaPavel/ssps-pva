using System;
					
public class Program
{
	public static void Main()
	{
		double f = 65.7;

		int k = (int)f;
		byte a = (byte)f;
		char ch = (char)f;
		
		Console.WriteLine(k);
		Console.WriteLine(a);
		Console.WriteLine(ch);
		
		// string s = (string)f; -- nelze!
		Console.WriteLine(Convert.ToString(f));
	}
}