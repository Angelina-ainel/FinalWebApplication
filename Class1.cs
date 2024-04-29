using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		int n;
		sum_even = 0;
		sum_odd = 0;
		n = int.Parse(Console.Readline());
		for (int i = 0; i =< n; i++)
		{ 
			if (i % 2 == 0)
				sum_even += i;
			else
				sum_odd += i;
	}
	}
}
