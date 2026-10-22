namespace DesignPatterns.App
{
    public class Application
    {
        private string[] _options = ["Factory", "Exit"];
        private int _selectedAnswer = 0;
        private bool _isRunning = true;

        public void Run()
        {
            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Welcome To Design Patterns in C# ===");
                Console.WriteLine();

                Console.WriteLine("Please select an option:");
                for (int i = 0; i < _options.Length; i++)
                {
                    Console.WriteLine(i == _selectedAnswer ? $"> {_options[i]}" : _options[i]);
                }

                ConsoleKeyInfo a = Console.ReadKey(intercept: true);
                if (a.Key == ConsoleKey.UpArrow)
                {
                    if(_selectedAnswer > 0) _selectedAnswer--;
                }
                else if (a.Key == ConsoleKey.DownArrow)
                {
                    if(_selectedAnswer < _options.Length - 1) _selectedAnswer++;
                }
            }
        }
    }
}