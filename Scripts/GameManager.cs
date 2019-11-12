using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    HealthManager healthManager;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        healthManager = FindObjectOfType<HealthManager>();

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHealth(int HealthToAdd)
    {
        
    }
}
