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
        rb.AddRelativeForce(Vector3.forward * bulletSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if (collision.gameObject.layer == 0)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
/*            collision.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
*/        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
