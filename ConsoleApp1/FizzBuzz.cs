namespace ConsoleApp1;

public class FizzBuzz {
	public string Convert(int number)
	{
		if (number == 3)
			return "Fizz";
		if (number == 5)
			return "Buzz";
		return number.ToString();
	}
}