using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    public string SkillName { get; protected set; }
    public int Damage { get; protected set; }
    public int Cooldown { get; protected set; }
    public int ManaCost { get; protected set; }
    public bool Ranged { get; protected set; }
    public bool Spell { get; protected set; }

    public Skill(string name, int damage, int cooldown, int manaCost, bool ranged, bool spell)
    {
        SkillName = name;
        Damage = damage;
        Cooldown = cooldown;
        ManaCost = manaCost;
        Ranged = ranged;
        Spell = spell;
    }
    public abstract void Cast(GameObject caster);
}
