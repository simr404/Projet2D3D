using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    [SerializeField] float speed;

    public bool activeMode;

    Rigidbody2D rb;
    int xDir;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        activeMode = false;
    }

    void FixedUpdate()
    {
        if(activeMode)
        {
            if(Input.GetAxis("Horizontal") > 0)
            {
                xDir = 1;
            }
            else if(Input.GetAxis("Horizontal") < 0)
            {
                xDir = -1;
            }
            else
            {
                xDir = 0;
            }

            rb.velocity = new Vector2(xDir * speed, rb.velocity.y);
        }
    }
}
