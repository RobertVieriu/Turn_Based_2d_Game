using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public int temporaryHealth;

    public StatusBar healthBar;


    public void TakeDamage(int amount)
    {
        if (temporaryHealth > 0)
        { 
            temporaryHealth -= amount;

            if(temporaryHealth < 0)
            {
                currentHealth += temporaryHealth;
                temporaryHealth = 0;
            }
        }
        else
        {
            currentHealth -= amount;
        }

        healthBar.UpdateStatusBar(maxHealth, currentHealth, temporaryHealth);
        healthBar.text.text = currentHealth.ToString();

        if (currentHealth <= 0)
        {
            Debug.Log("You're Dead!");
        }
    }


    public void HealDamage(int amount, int temp_amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        temporaryHealth += temp_amount;

       if (temporaryHealth > maxHealth)
       {
            temporaryHealth = maxHealth;
       }

        healthBar.UpdateStatusBar(maxHealth, currentHealth, temporaryHealth);
        healthBar.text.text = currentHealth.ToString();
    }
}
