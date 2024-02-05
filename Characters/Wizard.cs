namespace RPG_CHARACTER.Characters;

public class Wizard : Character
{
    public Wizard(String name) : base(name, "Wizard", "A hocus pocus person")
    {
        _allowedWeapons.Add(WeaponAttackType.Magic);
    }

    public void CastSpell()
    {
        Console.WriteLine("Cast a spell!");
    }
}