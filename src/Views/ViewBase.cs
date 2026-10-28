using DesignPatterns.App;

namespace DesignPatterns.Views
{
    public abstract class ViewBase : IView
    {
        protected readonly Application App;

        protected ViewBase(Application app)
        {
            App = app;
        }

        public abstract void Render();

        public virtual void Back()
        {
            ConsoleKeyInfo a = Console.ReadKey(intercept: true);
            if (a.Key == ConsoleKey.Backspace)
            {
                App.ChangeView(new MainScreen(App));
            }
        }
    }
}