using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            if (health > 100)
                health = maxHealth;

            if (health <= 0)
            {
                health = 0;
                Die();
            }
            healthBar.SetHealth(health);
        }
    }

    public HealthBar healthBar;

    void Start()
    {
        Health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void TakeHealth(int health)
    {
        Health += health;
    }

    public void Die()
    {
        Debug.Log("YOU DIED!");
        SceneManager.LoadScene("SampleScene");
    }
}
