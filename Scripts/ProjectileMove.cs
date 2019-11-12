using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float speed;
    public float fireRate;
    public float timer = 3.0f;
    public int damage = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        Destroy(gameObject, timer);
    }
    // Update is called once per frame
    void Update()
    {
        if(speed != 0)
        {
            transform.position += transform.forward * (speed * Time.deltaTime) * fireRate;
        }
        else
        {
            Debug.Log("No Speed");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<HealthManager>().HurtPlayer(damage);

        }

        if(other.gameObject.tag == "Enemy")
        {
            FindObjectOfType<EnemyHealth>().HurtEnemy(damage);
        }
    }
}
