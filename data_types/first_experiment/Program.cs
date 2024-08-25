using System;

public class Program
{
	public static void Main()
	{
		string s = "3.14";
		
		// Doplňte kód, který vypočítá a vypíše dvojnásobek hodnoty ve stringu s
		Console.WriteLine((Convert.ToDouble(s) * Convert.ToDouble(s)));
			
		// Konvertujte string s na čísla uvedených typů a vypište je
		double d = Convert.ToDouble(s);
		Console.WriteLine(d);
		
		float f = Convert.ToSingle(s);
		Console.WriteLine(f);
		
		decimal m = Convert.ToDecimal(s);
	    Console.WriteLine(m);
			
		long l = 5000;
		int i = (int)l;
		Console.WriteLine(i);
		
		l = 5000000000;
		i = (int)l;
		Console.WriteLine(i);
	}
}