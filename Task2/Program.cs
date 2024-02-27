List<string> words = new List<string>{ "hello"," ", "world"," ","!" };
string contact="The concatenated string is: ";
foreach (var i in words)
{
    contact+=i;
}
System.Console.Write( contact);