using System.Text.RegularExpressions;
using YoutubeExplode;

namespace YouTubeMp3;

public class GetVideoCommand : ICommand
{
    public bool Execute(string command)
    {
        var getVideoMatch = Regex.Match(command, "get (.*)");
        if (!getVideoMatch.Success) return false;

        return false;
    }

    private async Task DownloadVideo(string url)
    {
        var youtube = new YoutubeClient();

        var video = await youtube.Videos.GetAsync(url);



    }


}