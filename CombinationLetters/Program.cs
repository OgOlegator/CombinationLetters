Console.WriteLine("Введите строку");

var inString = Console.ReadLine();

if(string.IsNullOrEmpty(inString))
    return;

var result = CombinationsLatter.GetAllSequences(inString.ToArray());

foreach(var comb in result)
    Console.WriteLine(comb);

public class CombinationsLatter
{
    public static IEnumerable<String> GetAllSequences(char[] charsArr)
        => charsArr.SelectMany(x => GetCombs("", x, charsArr));

    private static List<string> GetCombs(string combination, char nextChar, char[] charsArr)
    {
        var newChars = charsArr.Where(x => x != nextChar).ToArray();

        combination += nextChar;

        if (newChars.Count() == 0)
            return new List<string> { combination };

        return newChars.SelectMany(x => GetCombs(combination, x, newChars)).ToList();
    }
}