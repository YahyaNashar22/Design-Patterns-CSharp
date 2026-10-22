using DesignPatterns.Animations;
using DesignPatterns.App;

namespace DesignPatterns
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Application app = new();
            RotatingGalaxyASCII.Play(2500);
            app.Run();
        }
    }
}