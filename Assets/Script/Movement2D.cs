using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public KeyCode KCLeft;
    public KeyCode KCRight;
    public float fSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KCRight))
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * fSpeed);
        if (Input.GetKey(KCLeft))
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * fSpeed);
    }
}
