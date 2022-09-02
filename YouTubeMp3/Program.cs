using VideoLibrary;
using MediaToolkit;

namespace YouTubeMp3 // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            const string? url = "https://www.youtube.com/watch?v=L5CV53wCWO0";
            var filepath = "C:\\Repos";
            var file = "data.mp4";
            string endresult =  Path.Combine(filepath, file);
            
            var item = new YouTube();
            var item2 = item.GetVideo(url);
            File.WriteAllBytes(endresult, item2.GetBytes());

            string outputFileName = Path.ChangeExtension(endresult, ".mp3");
        }


    }

}