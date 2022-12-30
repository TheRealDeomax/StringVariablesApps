// Common Variables
// string

string firstNameofUser = string.Empty;
string lastNameofUser = string.Empty;
string filePath = string.Empty;

// expertsExchange
// expert-sexchange

firstNameofUser = "Prajuk";
lastNameofUser = "Nusbaum";

// string literial
// filePath = "C:\Temp\Demo";

filePath = @"C:\Temp\Demo";

// string interpolation and string literials
string testString = $@"The file for {firstNameofUser} with {lastNameofUser} with {filePath}";

// string interpolation
Console.WriteLine(value: $"{firstNameofUser} {lastNameofUser}");
Console.WriteLine(filePath);
Console.WriteLine(testString);