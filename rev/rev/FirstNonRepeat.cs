using System;
using System.Collections.Generic;

public class FirstNonRepeat
{
	public static char FindFirst(string str)
	{
		Dictionary<char, int> freq = new Dictionary<char, int>();

		foreach (char c in str)
		{
			if (freq.ContainsKey(c))
				freq[c]++;
			else
				freq[c] = 1;
		}

		foreach (char c in str)
		{
			if (freq[c] == 1)
				return c;
		}

		return '\0'; 
	}
}
