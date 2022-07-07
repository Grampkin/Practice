// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Hello, World!");
TestValues1();
TestValues2();
Order.ShowOrderInfo();


void TestValues1()
{
    var a = new Quote(10, new(2, 0));
    var b = new Quote(3, new(3, 6));
    var sum = a.Add(b);
    const string knownSum = "13.56";
    if (sum.Value == knownSum)
    {
        Console.WriteLine($"Sum is {knownSum} is correct! Good job!");
    }
    else
    {
        Console.WriteLine($"You get {sum.Value} instead of {knownSum}, you donkey!");
    }
}
void TestValues2()
{
    var a = new Quote(10, new(7, 3));
    var b = new Quote(3, new(3, 6));
    var sum = a.Add(b);
    const string knownSum = "14.09";
    if (sum.Value == knownSum)
    {
        Console.WriteLine($"Sum is {knownSum} is correct! Good job!");
    }
    else
    {
        Console.WriteLine($"You get {sum.Value} instead of {knownSum}, you donkey!");
    }
}