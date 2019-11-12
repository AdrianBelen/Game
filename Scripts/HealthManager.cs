using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public Slider healthbar;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.value = CalculateHealth();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;
        healthbar.value = CalculateHealth();
        if(currentHealth == 0)
        {
            Die();
        }
    }

    float CalculateHealth()
    {
        return currentHealth;
    }

    public void HealPlayer(int health)
    {
        currentHealth += health;
        healthbar.value = CalculateHealth();    
    }
   
    void Die()
    {
        Debug.Log("u dead");
        Destroy(player);
    }
}
