using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletSpeed;
    public float bulletDamage;

    // Start is called before the first frame update
    void Start()
    {
        bulletSpeed = 3000;
        bulletDamage = 10;
        rb.AddRelativeForce(Vector3.forward * bulletSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
        }

        if (collision.gameObject.layer == 3)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().PlayerTakeDamage(bulletDamage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
