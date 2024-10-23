using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour
{
    [SerializeField] private Health health;
    public int speed;
    public int initiative;

    private void Start()
    {
        speed = 5;
        initiative = speed;
        health.maxHealth = 10;
        health.currentHealth = 10;
        health.temporaryHealth = 0;
        health.healthBar.UpdateStatusBar(health.maxHealth, health.currentHealth, health.temporaryHealth);
        health.healthBar.text.text = health.currentHealth.ToString();
        health.TakeDamage(2);
    }
}
