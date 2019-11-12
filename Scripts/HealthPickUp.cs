using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{

    HealthManager healthManager;
    public int healthValue;
    // Start is called before the first frame update
    void Awake()
    {
        healthManager = FindObjectOfType<HealthManager>();
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (healthManager.currentHealth < healthManager.maxHealth)
            {
                Destroy(gameObject);
                healthManager.HealPlayer(healthValue);
            }
        }
    }

  
}
