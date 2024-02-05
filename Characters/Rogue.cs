namespace RPG_CHARACTER.Characters;

public class Rogue : Character
{
    public Rogue(String name) : base(name, "Rogue", "a sneaky fellow")
    {
        _allowedWeapons.Add(WeaponAttackType.Melee);
        _allowedWeapons.Add(WeaponAttackType.Ranged);
    }
}