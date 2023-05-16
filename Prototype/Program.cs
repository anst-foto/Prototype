using Prototype;

var test_1 = new TestClass()
{
    Id = 5
};
var test_2 = test_1;
Console.WriteLine($"test_1 = {test_1.Id}");
Console.WriteLine($"test_2 = {test_2.Id}");
Console.WriteLine("--- --- ---");

test_2.Id = 10;
Console.WriteLine($"test_1 = {test_1.Id}");
Console.WriteLine($"test_2 = {test_2.Id}");
Console.WriteLine("--- --- ---");

var test_3 = test_1.Clone();
Console.WriteLine($"test_1 = {test_1.Id}");
Console.WriteLine($"test_2 = {test_2.Id}");
Console.WriteLine($"test_3 = {test_3.Id}");
Console.WriteLine("--- --- ---");

test_3.Id = 15;
Console.WriteLine($"test_1 = {test_1.Id}");
Console.WriteLine($"test_2 = {test_2.Id}");
Console.WriteLine($"test_3 = {test_3.Id}");
Console.WriteLine("--- --- ---");

var test_4 = new TestClass(test_3);
Console.WriteLine($"test_1 = {test_1.Id}");
Console.WriteLine($"test_2 = {test_2.Id}");
Console.WriteLine($"test_3 = {test_3.Id}");
Console.WriteLine($"test_4 = {test_4.Id}");
Console.WriteLine("--- --- ---");

test_4.Id = 20;
Console.WriteLine($"test_1 = {test_1.Id}");
Console.WriteLine($"test_2 = {test_2.Id}");
Console.WriteLine($"test_3 = {test_3.Id}");
Console.WriteLine($"test_4 = {test_4.Id}");
Console.WriteLine("--- --- ---");

var test_5 = new TestRecord(5);
Console.WriteLine($"test_5 = {test_5.Id}");

var test_6 = test_5 with { Id = 7 };
Console.WriteLine($"test_5 = {test_5.Id}");
Console.WriteLine($"test_6 = {test_6.Id}");
