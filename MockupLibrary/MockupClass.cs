namespace MockupLibrary
{
    public class MockupClass
    {
        public const string DEFAULT_GREETING_MESSAGE = "This is the default greeting message.";
        public const string DO_SOMETHING_MESSAGE = "\"{0}\" was the greeting message before we did something";

        public string GreetingMessage;

        public MockupClass() : this(DEFAULT_GREETING_MESSAGE)
        {

        }

        public MockupClass(string greetingMessage)
        {
            GreetingMessage = greetingMessage;
        }

        public void DoSomething()
        {
            GreetingMessage = string.Format(DO_SOMETHING_MESSAGE, ToString());
        }

        public override string ToString()
        {
            return GreetingMessage;
        }
    }
}