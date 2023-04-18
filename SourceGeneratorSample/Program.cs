# pragma warning disable CS8321
using GreetingTest;

Greeting.SayHelloTo("testName"); 
Lesson1Greeting();

static void Lesson1Greeting() => GreetingUsePartialClass.SayHelloTo("tetsPartialClass");