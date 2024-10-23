using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSlash : Skill
{
    public HeroSlash(string name, int damage, int cooldown, int manaCost, bool ranged, bool spell) : base(name, damage, cooldown, manaCost, ranged, spell){}
    
    private void Start()
    {
        SkillName = "Hero Slash";
        Damage = 10;
        Cooldown = 0;
    }

    public override void Cast(GameObject caster)
    {
        Debug.Log("Damage: " + Damage);
        if (caster == null)
        {
            Debug.LogError("Caster is null.");
        }

        // Get the target selected by the TargetSelect class
        TargetSelect targetSelect = caster.GetComponent<TargetSelect>();

        if (targetSelect == null)
        {
            Debug.LogError("TargetSelect component not found on caster.");
            return;
        }

        if (targetSelect.target == null)
        {
            Debug.LogError("No target selected.");
            return;
        }

        if (targetSelect.target != null && Cooldown == 0)
        {
            // Get the Health component from the target GameObject
            Health targetHealth = targetSelect.target.GetComponent<Health>();

            if (targetHealth != null)
            {
                targetHealth.TakeDamage(Damage); // Deal damage to the target
                Debug.Log($"{caster.name} casts {SkillName} on {targetSelect.target.name}, dealing {Damage} damage!");

                // Cooldown after casting
                Cooldown = 3;
            }
            else
            {
                Debug.LogWarning("Target does not have a Health component.");
            }
        }
        else
        {
            if (Cooldown > 0)
            {
                Debug.Log($"{SkillName} is not ready yet!");
            }
            else
            {
                Debug.Log("No valid target selected.");
            }
        }
    }
}
