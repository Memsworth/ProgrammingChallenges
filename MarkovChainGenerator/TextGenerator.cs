using System.Text.RegularExpressions;

namespace MarkovChainGenerator;

public static class TextGenerator
{
    private const string TextFile = @"C:\Repos\GitHub\ProgrammingChallenges\MarkovChainGenerator\inputArticle.txt";
    private static readonly Random Rand = new Random();

    private static void LoadFile(string filepath)
    {
        if (!File.Exists(filepath)) return;

        var cleanText = Regex.Replace(File.ReadAllText(filepath), @"/[^a-z0-9\-\s]/i", string.Empty);
        var splitText = cleanText.Split()
            .Where(word => !string.IsNullOrWhiteSpace(word)).ToList();
        
        
        var textEndDot = splitText.Where(word => word.EndsWith(".")).ToArray();
        var split = splitText.Except(textEndDot).ToArray();

        GenerateSentence(5, split, textEndDot);
    }

    private static void GenerateSentence(int i, string[] split, string[] textEndDot)
    {
        var sentence = Enumerable.Empty<string>().ToList();
        var startInitialWord = split[Rand.Next(split.Length)];
        sentence.Add(startInitialWord);
        while (i >= sentence.Count)
        {
            sentence.Add(FindNextWord(split, sentence));
        }
        
    }

    private static string FindNextWord(string[] split, List<string> sentence)
    {
        var indexOfStartElement = Enumerable.Empty<int>().ToList();
        string startElement = sentence.Last();
        Console.WriteLine(startElement);
        bool found = false;
        
        if (!found)
        {
            while (true)
            {
                var i = Rand.Next(split.Length);
                if (split[i] == "The" || split[i] == "the")
                {
                    continue;
                }
                else
                {
                    indexOfStartElement.Add(i);
                    break;
                }
            }
        }
        
        return split[Rand.Next(indexOfStartElement.Count)];
    }

    private static void PrintArray(string[] myArr)
    {
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write($"{myArr[i]}  ");
            if (i%4==0)
            {
                Console.WriteLine();
            }
        }
    }
    
    public static void RunProgram()
    {
        LoadFile(TextFile);
    }
}