using DesignPatterns.App;
using DesignPatterns.Utility;
using DesignPatterns.Views;

namespace DesignPatterns.Patterns
{
    public class Strategy : ViewBase
    {
        private string _patternName = "Strategy";
        public Strategy(Application app) : base(app)
        {

        }
        public override void Render()
        {
            throw new NotImplementedException();
        }

        private void Intro()
        {
            Console.WriteLine($"=== {_patternName} Pattern ===");
            Console.WriteLine();
            Console.WriteLine("The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.\nStrategy lets the algorithm vary independently from clients that use it.");

            DisplayUtilities.PrintPatternName(_patternName);
        }
    }
}