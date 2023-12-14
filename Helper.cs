
public class Helper
{
    protected List<char> _listOfLettersToCount;
    protected List<char> _listOfNumberToCount;
    private List<char> _illegalalCharacters;
    private int? _result;

    public Helper()
    {
        _listOfLettersToCount = ['a', 'b', 'c'];
        _listOfNumberToCount = ['1', '2', '3'];
        _illegalalCharacters = ['-', '<', '>'];
    }

    public bool IsCharacterAndIfINeedToCount(char character)
    {
        if (char.IsAsciiLetter(character)) 
        {
            var letter = character;

            if (_listOfLettersToCount.Contains(letter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;
    }

    public bool IsDigitAndIfItIsInTheList(char character)
    {
        if (char.IsDigit(character))
        {
            var letter = character;

            if (_listOfLettersToCount.Contains(letter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;
    }

    public void IncreaseDigitCount(int digitCount, bool b)
    {
        if (b)
        {
            digitCount++;
        }
    }

    public string GetResult() => _result.Value.ToString();

}