using Fighting.Weapons.Abstract;

namespace Fighting.Weapons.Improvements;
public class Sharpen : Decorator
{
    public Sharpen(Weapon weapon)
        : base(
            weapon: weapon,
            weapon.Damage,
            "Sharpen " + weapon.WeaponName)
    { }

    public override (int, string) Harm()
    {
        var harmResult = Weapon.Harm();
        var improvedDamage = harmResult.Item1 + (int)Constants.Refined;
        var newName = WeaponName;
        return (improvedDamage, newName);
    }
}
