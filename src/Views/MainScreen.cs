using DesignPatterns.App;
using DesignPatterns.Patterns.Factory;

namespace DesignPatterns.Views
{
    public class MainScreen : ViewBase
    {
        private readonly Application _app;
        private string[] _options = ["Factory", "Exit"];
        private int _selectedAnswer = 0;

        public MainScreen(Application app) : base(app)
        {
            _app = app;
        }
        public override void Render()
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
                if (_selectedAnswer > 0) _selectedAnswer--;
            }
            else if (a.Key == ConsoleKey.DownArrow)
            {
                if (_selectedAnswer < _options.Length - 1) _selectedAnswer++;
            }
            else if (a.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                switch (_options[_selectedAnswer])
                {
                    case "Factory":
                        _app.ChangeView(new Factory(App));
                        break;

                    case "Exit":
                        _app.Stop();
                        break;

                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }
            }

        }
    }
}