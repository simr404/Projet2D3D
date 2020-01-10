using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCube : MonoBehaviour
{
    Vector3 VRotate;
    public GameObject Cube;
    public enum TurnMap { Right, Left};
    public TurnMap TurnMovement;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Turn()
    {
        VRotate = Cube.transform.rotation.eulerAngles;
        print(VRotate);
        if (TurnMovement == TurnMap.Left)
        {
            Cube.transform.Rotate(new Vector3(0, 90));
        }
        else if (TurnMovement == TurnMap.Right)
        {
            Cube.transform.Rotate(new Vector3(0, -90));
        }
        Cube.transform.Rotate(new Vector3());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Turn();
        }
    }
}
