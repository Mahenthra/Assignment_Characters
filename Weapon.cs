namespace RPG_CHARACTER;

public enum  WeaponAttackType
{
    Ranged,
    Melee, 
    Magic
}

public class Weapon
{
    private String _name;
    private String _description;
    private String _attackMessage;
    public WeaponAttackType AttackType { get; }

    public Weapon(string name, string description, WeaponAttackType attackType)
    {
        _name = name;
        _description = description;
        AttackType = AttackType;
        
        // built the attack message
        _attackMessage = $"{AttackType} attack using a {_name} ({description}).";
    }

    public String Attack()
    {
        return _attackMessage;
    }
}