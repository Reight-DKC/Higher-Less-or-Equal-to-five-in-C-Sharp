string input = Console.ReadLine();
int number = Int32.Parse(input);

int module = number;

Console.WriteLine(module);

if (module > 5)
{
Console.WriteLine("Higher than five");
}  
else if (module < 5)
{
    Console.WriteLine("Less than five");
    }
    else if (module == 5)
    {
        Console.WriteLine("Equal to five");
    }

Console.WriteLine("\nProgram ended");
  
