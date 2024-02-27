List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 8 };
Console.Write("The filtered numbers are: ");

List<int> evenNumbers = numbers.FindAll(num => num % 2 == 0);
foreach (int item in evenNumbers)
{
    Console.Write($"{item}, ");
}
