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
            Console.WriteLine("=== Factory Pattern ===");
            Console.WriteLine("Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.");

            ConsoleKeyInfo a = Console.ReadKey(intercept: true);
            if (a.Key == ConsoleKey.Backspace)
            {
                App.ChangeView(new MainScreen(App));
            }
        }
    }
}