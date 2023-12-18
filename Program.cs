const string filePath = "input.txt";

try
{
    if (File.Exists(filePath))
    {
        var content = File.ReadAllText(filePath);

        int letterCount = content.Count(char.IsLetter);
        int digitCount = content.Count(char.IsDigit);   

        Console.WriteLine($"The file contains {letterCount} letters and {digitCount} digits.");
    }
    else
    {
        Console.WriteLine($"File not found at path: {filePath}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
