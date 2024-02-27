List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
int sum=0;
foreach (var i in numbers)
{
    sum+=i;
}
System.Console.WriteLine(sum);