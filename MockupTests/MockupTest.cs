using MockupLibrary;

namespace MockupTests
{
    public class MockupTestClass
    {
        const string CUSTOM_MESSAGE = "Hi! This is a custom message!";

        MockupClass test;

        [SetUp]
        public void Setup()
        {
            test = new MockupClass();
        }

        [Test]
        public void Test()
        {
            Assert.That(test.ToString(), Is.EqualTo(test.GreetingMessage));
            Assert.That(test.ToString(), Is.EqualTo(MockupClass.DEFAULT_GREETING_MESSAGE));

            test.GreetingMessage = CUSTOM_MESSAGE;
            Assert.That(test.ToString(), Is.EqualTo(test.GreetingMessage));
            Assert.That(test.ToString(), Is.EqualTo(CUSTOM_MESSAGE));

            test.DoSomething();
            Assert.That(test.ToString(), Is.EqualTo(test.GreetingMessage));
            Assert.That(test.ToString(), Is.EqualTo(string.Format(MockupClass.DO_SOMETHING_MESSAGE, CUSTOM_MESSAGE)));
        }
    }
}