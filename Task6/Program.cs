List<bool> values = new List<bool> { true, true, false, true };

bool allTrue = values.All(b => b == true);

if (allTrue)
{
    Console.WriteLine("Are all the values in the list true?" + allTrue);
}
else
{
    Console.WriteLine("Not all the values in the list true." + allTrue);
}
