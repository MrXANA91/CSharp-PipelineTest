// See https://aka.ms/new-console-template for more information
using MockupLibrary;

Console.WriteLine("Hello, World!");

MockupClass mockupClass = new MockupClass();

Console.WriteLine(mockupClass.ToString());

mockupClass.DoSomething();
Console.WriteLine(mockupClass.GreetingMessage);