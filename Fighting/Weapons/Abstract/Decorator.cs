namespace Fighting.Weapons.Abstract;
public abstract class Decorator : Weapon
{
    protected readonly Weapon Weapon;

    protected Decorator(Weapon weapon, int damage, string name) : base(damage, name)
    {
        Weapon = weapon;
    }
}