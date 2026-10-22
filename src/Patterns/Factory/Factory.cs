using DesignPatterns.App;
using DesignPatterns.Views;

namespace DesignPatterns.Patterns.Factory
{
    public class Factory : ViewBase
    {
        public Factory(Application app) : base(app)
        {

        }
        public override void Render()
        {
            Console.WriteLine("Hello");

            ConsoleKeyInfo a = Console.ReadKey(intercept: true);
            if (a.Key == ConsoleKey.Backspace)
            {
                App.ChangeView(new MainScreen(App));
            }
        }
    }
}