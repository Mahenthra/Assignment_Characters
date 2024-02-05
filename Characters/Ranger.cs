namespace RPG_CHARACTER.Characters;

public class Ranger : Character
{
    public Ranger(String name) 
        : base(name,"Ranger", "a merry person of the woods")
    {
        _allowedWeapons.Add(WeaponAttackType.Ranged);
    }
}


