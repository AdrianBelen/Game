using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
        if (currentHealth == 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Killed Enemy");
        Destroy(enemy);
    }
}
