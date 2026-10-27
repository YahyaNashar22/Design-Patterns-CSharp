using DesignPatterns.App;
using DesignPatterns.Utility;
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
            Intro();

            ConsoleKeyInfo a = Console.ReadKey(intercept: true);
            if (a.Key == ConsoleKey.Backspace)
            {
                App.ChangeView(new MainScreen(App));
            }
        }

        private void Intro()
        {
            Console.WriteLine("=== Factory Pattern ===");
            Console.WriteLine();
            Console.WriteLine("Factory Method is a creational design pattern that provides an interface for creating objects in a superclass,\nbut allows subclasses to alter the type of objects that will be created.");

            DisplayUtilities.PrintPatternName("Factory");
        }
    }
}