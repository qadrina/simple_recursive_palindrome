using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Is it a palindrome?");
		Console.WriteLine(palindrome("kasUr ru Sa K"));
	}
	
	public static string palindrome(string s)
	{
		s = s.ToLower().Replace(" ", "");
		if (s.Length <= 1)
		{
			//return true;
			return "Yes";
		}
		else if (s[0] != s[s.Length - 1])
		{
			//return false;
			return "No";
		}
		else
		{
			return palindrome(s.Substring(1, s.Length - 2));
		}
	}
}
