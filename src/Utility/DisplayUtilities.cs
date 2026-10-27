namespace DesignPatterns.Utility
{
    public abstract class DisplayUtilities
    {
        public static void PrintPatternName(string name)
        {
            Console.WriteLine();

            Console.WriteLine(
                $"""
                  .---------.
                  |.-------.|
                  ||>run#  ||
                  ||       || {name}
                  |"-------'| Pattern
                .-^---------^-.
                | ---~  Yahya |
                "-------------'

                """
            );

            Console.WriteLine();
        }
    }
}