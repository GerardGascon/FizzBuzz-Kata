namespace ConsoleApp1;

public abstract class Program {
	private static void Main() {
		string? line = Console.ReadLine();
		FizzBuzz fizzBuzz = new();

		while (line != null) {
			if (!int.TryParse(line, out int number))
				break;
			Console.WriteLine(fizzBuzz.Convert(number));

			line = Console.ReadLine();
		}
	}
}