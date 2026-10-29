using DesignPatterns.App;
using DesignPatterns.Utility;
using DesignPatterns.Views;
using DesignPatterns.Patterns.StrategyPattern;

namespace DesignPatterns.Patterns
{
    public class Strategy(Application app) : ViewBase(app)
    {
        private string _patternName = "Strategy";

        public override void Render()
        {
            Intro();
            Back();
        }

        private void Intro()
        {


            Console.WriteLine($"=== {_patternName} Pattern ===");
            Console.WriteLine();
            Console.WriteLine("The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.\nStrategy lets the algorithm vary independently from clients that use it.");


            DisplayUtilities.Divider();

            StrategyImplementationRunner strategyImplementationRunner = new();
            strategyImplementationRunner.Run();

            DisplayUtilities.Divider();

            DisplayUtilities.PrintPatternName(_patternName);
        }
    }
}