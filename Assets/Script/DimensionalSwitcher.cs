using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionalSwitcher : MonoBehaviour
{
    public bool is3Dimension;
    public GameObject Player3D;
    public GameObject Player2D;

    void Awake()
    {
        is3Dimension = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) == true)
        {
            Move move3D = Player3D.GetComponent<Move>();
            Move2D move2D = Player2D.GetComponent<Move2D>();
            if(is3Dimension)
            {
                is3Dimension = false;
                move3D.activeMode = false;
                move2D.activeMode = true;
            }
            else
            {
                is3Dimension = true;
                move3D.activeMode = true;
                move2D.activeMode = false;
            }
        }
    }
}
