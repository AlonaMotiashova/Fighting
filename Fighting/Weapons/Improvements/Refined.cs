using Fighting.Weapons.Abstract;

namespace Fighting.Weapons.Improvements;
public class Refined : Decorator
{
    public Refined(Weapon weapon) :
        base(weapon,
            weapon.Damage,
            $"Refined {weapon.WeaponName}")
    { }

    public override (int, string) Harm()
    {
        var harmResult = Weapon.Harm();
        var improvedDamage = harmResult.Item1 + (int)Constants.Refined;
        var newName = WeaponName;
        return (improvedDamage, newName);
    }
}
