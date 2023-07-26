
Console.Write("Hello what is your name ");

string firstName  = Console.ReadLine();

if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Welcome Professor");
}
else
{
    Console.WriteLine($"Hello welcome to the class {firstName}");
}
