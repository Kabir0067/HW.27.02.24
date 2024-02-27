List<double> numbers = new List<double> { 3.5, 2.7, 6.9, 1.2 };

double sum = numbers.Sum();
double average = sum / numbers.Count;

System.Console.WriteLine($"The average value of all the elements in the list is: {average}");