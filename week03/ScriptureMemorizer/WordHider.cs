using System;
using System.Linq;
using System.Text.RegularExpressions;

class WordHider
{
    private static Random random = new Random();

    public static string MaskRandomWord(string Scriptures)
    {
        var wordsAndSeparators = Regex.Matches(Scriptures, @"(\w+|[^\w\s]+|\s+)")
        .Cast<Match>()
        .Select(m => m.Value)
        .ToList();

        var words = wordsAndSeparators.Where(s => Regex.IsMatch(s, @"\w+")).ToList();

        if (!words.Any()) return Scriptures;

        int randomIndex = random.Next(0, words.Count);
        string wordToHide = words[randomIndex];
        string maskedWord = new string('*', wordToHide.Length);

        for (int i = 0; i < wordsAndSeparators.Count; i++)
        {
            if (Regex.IsMatch(wordsAndSeparators[i], $@"\b{Regex.Escape(wordToHide)}\b"))
            {
                wordsAndSeparators[i] = maskedWord;
                break;
            }
        }
        return string.Join("", wordsAndSeparators);
    }
}