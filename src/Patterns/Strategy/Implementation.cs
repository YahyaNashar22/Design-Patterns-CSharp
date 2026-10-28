namespace DesignPatterns.Patterns.StrategyPattern
{
    interface IReloadable
    {
        void Reload();
    }
    abstract class Weapon
    {
        public abstract void Attack();
    }
    class Knife : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("stab stab stab");
        }
    }

    class Pistol : Weapon, IReloadable
    {
        public override void Attack()
        {
            Console.WriteLine("pew pew");
        }

        public void Reload()
        {
            Console.WriteLine("reloading . . .");
        }
    }

    class AK47 : Weapon, IReloadable
    {
        public override void Attack()
        {
            Console.WriteLine("ta ta ta ta ta ");
        }

        public void Reload()
        {
            Console.WriteLine("reloading . . .");
        }
    }





    class ImplementationRunner() : IImplementationRunner
    {

        public void Run()
        {

        }
    }


}