using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace ImageTwoASCII;

public static class ConvertMethods
{
    public static int[,] GetBrightnessData(Image<Rgb24> imageInput)
    {
        var brightnessValues = new int[imageInput.Width, imageInput.Height];
        for (int i = 0; i < imageInput.Width; i++)
        {
            for (int j = 0; j < imageInput.Height; j++)
            {
                var r = imageInput[i, j].R;
                var g = imageInput[i, j].G;
                var b = imageInput[i, j].B;
                brightnessValues[i, j] = (r + g + b) / 3;
            }
        }
        return brightnessValues;
    }
    
    public static void PrintPhoto(int[,] brightValues)
    {
        var charsToPrint = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$".ToArray();
        
        for (int i = 0; i < brightValues.GetLength(1); i++)
        {
            for (int j = 0; j < brightValues.GetLength(0); j++)
            {
                int avg = brightValues[j, i] / 4;
                Console.Write(charsToPrint[avg]);
            }
            Console.WriteLine();
        }
    }
}