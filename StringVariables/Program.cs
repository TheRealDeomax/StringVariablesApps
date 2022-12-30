// Common Variables
// string

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Prajuk";
lastName = "Nusbaum";
//filePath = "C:\Temp\Demo";
filePath = @"C:\Temp\Demo";

// string interpolation
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine(filePath);
