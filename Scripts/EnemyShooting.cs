using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float fireRate;
    public float nextFire;


    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        Shoot();

    }

    void Shoot()
    {
        if(Time.time > nextFire)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            nextFire = Time.time + fireRate;
        }
        
    }

}
