using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterStats : MonoBehaviour
{
    /*[SerializeField]
    private Animator animator;

    [SerializeField]
    private GameObject healthFill;

    [SerializeField]
    private GameObject magicFill;

    [Header("Stats")]
    public float health;
    public float magic;
    public float attack;
    public float defense;
    public float range;
    public float speed;
    public float experience;

    private float startHealth;
    private float startMagic;

    [HideInInspector]
    public int nextActTurn;

    private bool dead = false;

    // Resize health bar and magic bar
    private Transform healthTransform;
    private Transform magicTransform;

    private Vector2 healthScale;
    private Vector2 magicScale;

    private float xNewHealthScale;
    private float xNewMagicScale;

    private void Start()
    {
        healthTransform = healthFill.GetComponent<RectTransform>();
        healthScale = healthFill.transform.localScale;

        magicTransform = magicFill.GetComponent<RectTransform>();
        xNewMagicScale = magicFill.transform.localScale;

        startHealth = health;
        startMagic = magic;
    }

    public void ReceiveDamage(float damage)
    {
        health = health - damage;
        animator.Play("Damage");

        // Set damage text

        if(health <= 0)
        {
            dead = true;
            gameObject.tag = "Dead";
            Destroy(healthFill);
            Destroy(gameObject);
        } else
        {
            xNewHealthScale = healthScale.x * (health / startHealth);
            healthFill.transform.localScale = new Vector2(xNewHealthScale, healthScale.y);
        }
    }

    public void updateMagicFill(float cost)
    {
        magic -= cost;
        xNewMagicScale = magicScale.x * (magic / startMagic);
        magicFill.transform.localScale = new Vector2(xNewMagicScale, magicScale.y);
    }*/
}