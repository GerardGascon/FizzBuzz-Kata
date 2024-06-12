using ConsoleApp1;

namespace TestProject1;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void Convert1To1() {
		Assert.AreEqual("1", new FizzBuzz().Convert(1));
	}
}