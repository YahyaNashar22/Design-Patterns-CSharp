namespace DesignPatterns.Patterns.StrategyPattern
{
    interface IWeaponBehavior
    {
        public void PerformAttack();
    }
    class StabBehavior() : IWeaponBehavior
    {
        public void PerformAttack()
        {
            Console.WriteLine("stab stab stab");
        }
    }

    class SlashBehavior() : IWeaponBehavior
    {
        public void PerformAttack()
        {
            Console.WriteLine("slash slash slash");
        }
    }
    abstract class Weapon
    {
        private IWeaponBehavior _weaponBehavior;

        public Weapon(IWeaponBehavior weaponBehavior)
        {
            _weaponBehavior = weaponBehavior;
        }
        public void Attack()
        {
            _weaponBehavior.PerformAttack();
        }

        public void SetWeaponBehavior(IWeaponBehavior weaponBehavior)
        {
            _weaponBehavior = weaponBehavior;
        }
    }

    class Knife : Weapon
    {
        public Knife() : base(new StabBehavior())
        {

        }
    }

    public class StrategyImplementationRunner() : IImplementationRunner
    {
        public void Run()
        {
            Weapon knife = new Knife();
            knife.Attack();

            knife.SetWeaponBehavior(new SlashBehavior());
            knife.Attack();
        }
    }
}