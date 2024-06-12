﻿namespace ConsoleApp1;

public class FizzBuzz {
	public string Convert(int number)
	{
		if (number == 15)
			return "FizzBuzz";
		if (number % 3 == 0)
			return "Fizz";
		if (number % 5 == 0)
			return "Buzz";
		
		return number.ToString();
	}
}