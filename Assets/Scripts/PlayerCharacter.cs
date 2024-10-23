using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] private Health health;
    public int speed;
    public int initiative;


    private void Start()
    {
        speed = 10;
        initiative = speed;
        health.maxHealth = 25;
        health.currentHealth = 15;
        health.temporaryHealth = 0;
        health.healthBar.UpdateStatusBar(health.maxHealth, health.currentHealth, health.temporaryHealth);
        health.healthBar.text.text = health.currentHealth.ToString();
        health.TakeDamage(5);
    }
}
