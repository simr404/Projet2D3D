using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;

    public bool activeMode;

    Rigidbody rb;
    int xDir, zDir;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        activeMode = true;
    }

    void FixedUpdate()
    {
        if (activeMode)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                xDir = 1;
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                xDir = -1;
            }
            else
            {
                xDir = 0;
            }

            if (Input.GetAxis("Vertical") > 0)
            {
                zDir = 1;
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                zDir = -1;
            }
            else
            {
                zDir = 0;
            }

            rb.velocity = new Vector3(xDir * speed, rb.velocity.y, zDir * speed);
        }

        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
