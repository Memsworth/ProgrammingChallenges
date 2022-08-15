using System.Drawing;

namespace ImageTwoASCII // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Image newImage = Image.FromFile("SampImag.jpg");
        }
    }

}