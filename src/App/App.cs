using DesignPatterns.Views;

namespace DesignPatterns.App
{
    public class Application
    {
        public bool IsRunning { get; private set; } = true;
        public IView? CurrentView { get; private set; }

        public Application()
        {
            CurrentView = new MainScreen(this);
        }

        public void ChangeView(IView view)
        {
            CurrentView = view;
        }

        public void Stop()
        {
            Console.WriteLine("See you later!");
            IsRunning = false;
        }
        public void Run()
        {
            while (IsRunning)
            {
                CurrentView?.Render();
            }
        }
    }
}