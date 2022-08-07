namespace MarkovChainGenerator;

public class TextGenerator
{
    private static readonly string rootFolder = @"C:\Repos\GitHub\ProgrammingChallenges\MarkovChainGenerator\";

    private static readonly string textFile =
        @"C:\Repos\GitHub\ProgrammingChallenges\MarkovChainGenerator\inputArticle.txt";
    public static void RunProgram()
    {
        if (!File.Exists(textFile)) return;
        var text = File.ReadAllText(textFile);
        Dictionary<string, int> textRepeat = new Dictionary<string, int>();

        string[] words = text.Split();

        int total = 0;
        foreach (var word in words)
        {
            total++;
            if (!textRepeat.ContainsKey(word))
            {
                textRepeat.Add(word,1);
            }
            else
            {
                textRepeat[word]++;
            }
        }
        
        foreach (KeyValuePair<string, int> pair in textRepeat)
        {
            Console.WriteLine($"{pair.Key}:{pair.Value/total:F7}");
        }

        Console.WriteLine($"Total = {total}");
    }
}