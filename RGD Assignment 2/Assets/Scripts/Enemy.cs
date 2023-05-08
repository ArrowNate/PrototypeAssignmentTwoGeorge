using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float speed;
    public float rotationSpeed;
    public float jumpStrength;
    public Rigidbody rb;

    public Transform bulletSpawnPoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shooting", 4, 1);
    }

    void Shooting()
    {
        Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
