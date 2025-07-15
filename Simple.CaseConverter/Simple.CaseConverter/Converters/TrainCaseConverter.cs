using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple.CaseConverter.Extensions;

namespace Simple.CaseConverter.Converters;

public static class TrainCaseConverter
{
    public static string ConvertToTrainCase(string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        var words = SplitWords(input);
        return string.Join("-", words.Select(Capitalize));
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

    private static string Capitalize(string word)
    {
        return word.Length switch
        {
            0 => word,
            1 => char.ToUpper(word[0]).ToString(),
            _ => char.ToUpper(word[0]) + word.Substring(1).ToLower()
        };
    }
}