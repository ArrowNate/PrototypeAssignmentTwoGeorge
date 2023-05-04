using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public float speed;
    public float rotationSpeed;
    public float jumpStrength;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, rotationSpeed, 0, Space.Self);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, -rotationSpeed, 0, Space.Self);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpStrength);
        }
    }
}
