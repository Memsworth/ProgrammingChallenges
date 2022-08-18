using System.Text.RegularExpressions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using static ImageTwoASCII.ConvertMethods;

namespace ImageTwoASCII;

public class ConvertCommand : ICommand
{
    public bool Execute(string input)
    {
        var loadMatch = Regex.Match(input!, "convert (.*)");
        if (!loadMatch.Success) return false;
        var filePath = loadMatch.Groups[1].Value;
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException();

            try
            {
                Image.Identify(filePath, out var format);
                if (format!=null)
                {
                    var imageInput = Image.Load<Rgb24>(filePath);
                    var data = GetBrightnessData(imageInput);
                    PrintPhoto(data);
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("This isn't an image file");
                return false;
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"{new ArgumentException("File doesn't exist")}");
            return false;
        }
        
        return true;
    }
}