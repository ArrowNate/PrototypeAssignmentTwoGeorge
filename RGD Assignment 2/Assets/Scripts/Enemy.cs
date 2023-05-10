using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public float speed;
    public float rotationSpeed;
    public float jumpStrength;
    public bool playerInRange = false;
    public Rigidbody rb;
    public Transform player = null;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = true;
            player = other.transform;
            Debug.Log("Player Entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = false;
            player = null;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.tag == "Bullet")
        {
            health -= 10;
            Debug.Log("Hit");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            transform.rotation = Quaternion.LookRotation(player.position - transform.position, transform.up);
        }
    }
}
