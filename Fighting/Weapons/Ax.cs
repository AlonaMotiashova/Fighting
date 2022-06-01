﻿using Fighting.Weapons.Abstract;

namespace Fighting.Weapons;
public class Ax : Weapon
{
    private const string HarmPhrase = "The (name) is hacking";

    public Ax(int damage, string weaponName) : base(damage, weaponName)
    {
    }

    public override (int, string) Harm() =>
        (Damage, HarmPhrase.Replace("(name)", WeaponName));
}
