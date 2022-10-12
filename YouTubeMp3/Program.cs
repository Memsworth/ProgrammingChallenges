using VideoLibrary;
using MediaToolkit;
using MediaToolkit.Model;

namespace YouTubeMp3 // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine() ?? throw new InvalidOperationException();
            var youTubeItem = YouTube.Default;
            YouTubeVideo video = youTubeItem.GetVideo(url);
            var bytes = video.GetBytes();
            

            var inputFile = new MediaFile { Filename = video.FullName };
            var outputFile = new MediaFile { Filename = @"C:\Users\Abubakar\Music\name.mp3" };

            using (var engine = new Engine())
            {
                engine.Convert(inputFile, outputFile);
            }
        }
    }

}
