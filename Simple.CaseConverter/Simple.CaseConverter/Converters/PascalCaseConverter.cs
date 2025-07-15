using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.CaseConverter.Extensions;

namespace Simple.CaseConverter.Converters;

public static class PascalCaseConverter
{
    public static string ConvertToPascalCase(string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        var words = SplitWords(input);
        var result = new StringBuilder();

        foreach (var word in words.Where(word => word.Length > 0))
        {
            result.Append(char.ToUpperInvariant(word[0]));
            
            if (word.Length > 1)
            {
                result.Append(word[1..].ToLowerInvariant());
            }
        }

        return result.ToString();
    }

    private static List<string> SplitWords(string input)
    {
        var result = new List<string>();
        var word = new StringBuilder();

        foreach (var currentChar in input)
        {
            if (!char.IsLetterOrDigit(currentChar))
            {
                if (word.Length > 0)
                {
                    result.Add(word.ToString());
                    word.Clear();
                }

                continue;
            }

            if (word.Length == 0)
            {
                word.Append(currentChar);
                continue;
            }

            var previous = word[^1];

            var isBoundary =
                (char.IsUpper(currentChar) && (char.IsLower(previous) || char.IsDigit(previous))) ||
                (char.IsDigit(currentChar) && char.IsLetter(previous)) ||
                (char.IsLetter(currentChar) && char.IsDigit(previous));

            if (isBoundary)
            {
                result.Add(word.ToString());
                word.Clear();
            }

            word.Append(currentChar);
        }

        if (word.Length > 0)
        {
            result.Add(word.ToString());
        }

        return result;
    }
}