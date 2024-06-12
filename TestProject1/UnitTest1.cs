using ConsoleApp1;

namespace TestProject1;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void Convert1To1() {
		Assert.That(new FizzBuzz().Convert(1), Is.EqualTo("1"));
	}

	[Test]
	public void Convert2To2() {
		Assert.That(new FizzBuzz().Convert(2), Is.EqualTo("2"));
	}
}