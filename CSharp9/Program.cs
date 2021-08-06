//System.Console.WriteLine("Hello World!"); // Top-Level Statement

namespace CSharp9
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args is not null)
            {

            }
            char myCharacter = 'm';
        }

        public static bool IsLetter(this char c)
        {
            return c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        }
    }
}
