using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shooting", 4, 1);
    }

    void Shooting()
    {
        Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
