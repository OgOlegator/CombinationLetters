Console.WriteLine("Введите строку");

var inString = Console.ReadLine();

var result = Combination.GetAllSequences(inString.ToArray());

foreach(var comb in result)
    Console.WriteLine(comb);

public class Combination
{
    public static IEnumerable<String> GetAllSequences(char[] chars)
        => chars.SelectMany(x => GetCombs("", x, chars));

    private static List<string> GetCombs(string combination, char nextChar, char[] chars)
    {
        var newChar = chars.Where(x => x != nextChar).ToArray();

        combination += nextChar;

        if (newChar.Count() == 0)
            return new List<string> { combination };

        return newChar.SelectMany(x => GetCombs(combination, x, newChar)).ToList();
    }
}