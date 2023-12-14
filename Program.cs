const string filePath = "input.txt";
int letter_count = 0;
int DigitCount = 0;
try
{
    using var reader = new StreamReader(filePath);

    while (!reader.EndOfStream)
    {

        var line = reader.ReadLine()!;

        foreach (var character in line)
        {
            var helper = new Helper();

            var isCharacter = helper.IsCharacterAndIfINeedToCount(character);
            var isDigit = helper.IsDigitAndIfItIsInTheList(character);

            IncreaseLetter_CountIfTrue(letter_count, isCharacter);
            helper.IncreaseDigitCount(DigitCount, isDigit);
        }
        
        void IncreaseLetter_CountIfTrue(int letter_countt, bool isCharacter)
        {
            letter_count = isCharacter ? ++letter_count : letter_count;
        }
    }       
}
catch (FileNotFoundException)
{
    Console.WriteLine($"File was not found in provided path");
}

Console.WriteLine($"The file contains {letter_count} letters and {DigitCount} digits.");
Console.ReadKey();

Console.WriteLine($"The file contains {new Helper().GetResult()}");
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
return;
