using ConsoleApp1;

namespace TestProject1;

public class Tests {
	[SetUp]
	public void Setup() { }

	private static IEnumerable<TestCaseData> NumberConversionData() {
		yield return new TestCaseData(1, "1");
		yield return new TestCaseData(2, "2");
		yield return new TestCaseData(4, "4");
	}
	[Test, TestCaseSource(nameof(NumberConversionData))]
	public void ConvertIntToString(int number, string expectedResult) {
		Assert.That(new FizzBuzz().Convert(number), Is.EqualTo(expectedResult));
	}

	private static IEnumerable<TestCaseData> FizzConversionData() {
		yield return new TestCaseData(3);
		yield return new TestCaseData(6);
		yield return new TestCaseData(9);
	}
	[Test, TestCaseSource(nameof(FizzConversionData))]
	public void ConvertToFizz(int number) {
		Assert.That(new FizzBuzz().Convert(number), Is.EqualTo("Fizz"));
	}

	private static IEnumerable<TestCaseData> BuzzConversionData() {
		yield return new TestCaseData(5);
		yield return new TestCaseData(10);
		yield return new TestCaseData(20);
	}
	[Test, TestCaseSource(nameof(BuzzConversionData))]
	public void ConvertToBuzz(int number) {
		Assert.That(new FizzBuzz().Convert(number), Is.EqualTo("Buzz"));
	}

	[Test]
	public void Convert15ToFizzBuzz() {
		Assert.That(new FizzBuzz().Convert(15), Is.EqualTo("FizzBuzz"));
	}
}