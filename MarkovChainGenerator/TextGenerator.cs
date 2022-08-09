using System.Text.RegularExpressions;

namespace MarkovChainGenerator;

public static class TextGenerator
{
    private const string TextFile = @"C:\Repos\GitHub\ProgrammingChallenges\MarkovChainGenerator\inputArticle.txt";
    private const string CollectionOfEngWords = @"C:\Repos\GitHub\ProgrammingChallenges\MarkovChainGenerator\words.txt";
    private static void LoadFile(string filepath, HashSet<string> engWords)
    {
        if (!File.Exists(filepath)) return;

        var cleanText = Regex.Replace(File.ReadAllText(filepath), @"/[^a-z0-9\-\s]/i", string.Empty);
        var splitText = cleanText.Split()
            .Where(word => !string.IsNullOrWhiteSpace(word)).ToArray();
        
        var textEndDot = splitText.Where(word => word.EndsWith(".")).ToArray();

    }

    private static void FindNextWord()
    {
        
    }
    private static void GenerateSentence()
    {
        
    }
    public static void RunProgram()
    {
        var englishWordsCollection = new HashSet<string>(File.ReadAllLines(CollectionOfEngWords));
        
        LoadFile(TextFile, englishWordsCollection);
    }
}