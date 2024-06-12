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
}