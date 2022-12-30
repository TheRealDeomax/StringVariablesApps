// Common Variables
// string

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Prajuk";
lastName = "Nusbaum";

// string literial
// filePath = "C:\Temp\Demo";

filePath = @"C:\Temp\Demo";

// string interpolation and string literials
string testString = $@"The file for {firstName} with {lastName} with {filePath}";

// string interpolation
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(testString);