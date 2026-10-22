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
    }
}