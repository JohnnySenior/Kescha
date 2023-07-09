Console.Write("Type your name: ");
string firstName = Console.ReadLine();

Console.WriteLine($"Hello, {firstName}");

Console.Write("Type your age: ");
string ageAsString = Console.ReadLine();
int age = int.Parse(ageAsString);

Console.WriteLine("Converting...");
Console.WriteLine($"Succesfully converted. Your age is {age}.");

int ageKescha = 3;
int differenceAge = age - ageKescha;

Console.WriteLine($"Difference your and Kescha's age is {differenceAge}.");

