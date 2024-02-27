List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

numbers.Add(10);
Console.WriteLine("___________________________________");
foreach (int number in numbers)
{
    Console.Write(number + " ");
    System.Console.WriteLine("___________________________________");
}

