using DesignPatterns.App;
using DesignPatterns.Utility;
using DesignPatterns.Views;

namespace DesignPatterns.Patterns
{
    public class Observer(Application app) : ViewBase(app)
    {
        private string _patternName = "Observer";

        public override void Render()
        {
            Intro();
            Back();
        }

        private void Intro()
        {


            Console.WriteLine($"=== {_patternName} Pattern ===");
            Console.WriteLine();
            Console.WriteLine("The Observer Pattern defines a one-to-many dependency between objects so that when one object changes state, all of its dependents are notified and updated automatically.");


            DisplayUtilities.Divider();


            DisplayUtilities.Divider();

            DisplayUtilities.PrintPatternName(_patternName);
        }
    }
}