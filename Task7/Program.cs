List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

foreach (int item in numbers)
{
    Console.Write(item +" ");
}

numbers.RemoveAt(4);

Console.WriteLine("\n_______________________________\n");
foreach (int item in numbers)
{
    Console.Write(item + " ");
}
