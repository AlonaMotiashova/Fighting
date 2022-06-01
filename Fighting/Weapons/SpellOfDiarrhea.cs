namespace Fighting.Weapons;
public class SpellOfDiarrhea : Abstract.Weapon
{
    private const string HarmPhrase = "The (name) causes diarrhea in enemies";

    public SpellOfDiarrhea(int damage, string weaponName) : base(damage, weaponName)
    {
    }

    public override (int, string) Harm() =>
        (Damage, HarmPhrase.Replace("(name)", WeaponName));

}
