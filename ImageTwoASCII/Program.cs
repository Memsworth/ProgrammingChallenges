using SixLabors;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace ImageTwoASCII // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string? path = "C:\\Users\\Memsworth\\Pictures\\pepeTheFrog.png";

            var charsToPrint = "`^\",:;Il!i~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$".ToArray();

            var pepeImage = Image.Load<Rgb24>(path);
            var brightValues = new int[pepeImage.Width, pepeImage.Height];
            
            for (int i = 0; i < pepeImage.Width; i++)
            {
                for (int j = 0; j < pepeImage.Height; j++)
                {
                    var r = pepeImage[i, j].R;
                    var g = pepeImage[i, j].G;
                    var b = pepeImage[i, j].B;
                    brightValues[i, j] = (r + g + b) / 3;
                }
            }

            var items = brightValues.Cast<int>().Distinct().Count();
            PrintPhoto(brightValues, charsToPrint);
        }

        private static void PrintPhoto(int[,] brightValues, char[] charsToPrint)
        {
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

}