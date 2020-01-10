using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public float Speed = 0.18f;

    public float JumpForce = 0.18f;


    private bool CanJump = false;

    private void Movement()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);

        }
        if (CanJump == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                CanJump = false;

            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other.tag);

        if (other.tag == "Ground")
        {
            Debug.Log("landed");
            CanJump = true;
        }

    }


    void Update()
    {
        Movement();
    }
}
