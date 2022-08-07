namespace FizzBuzz // Note: actual namespace depends on the project name.
{
    
    //Sensei's Solution
    internal static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                var result = string.Empty;
                var isFizz = i % 3 == 0;
                if (isFizz)
                {
                    result += "Fizz ";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                else if (!isFizz)
                {
                    result += i.ToString();
                }
                
                Console.WriteLine(result);
            }
            
        }
    }

}