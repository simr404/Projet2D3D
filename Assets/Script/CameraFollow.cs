using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] Transform player3D;
    [SerializeField] Transform player2D;

    bool is3Dimension;

    void Awake()
    {
        is3Dimension = true;
    }

    // Update is called once per frame
    void Update()
    {
        is3Dimension = GameObject.Find("GameManager").GetComponent<DimensionalSwitcher>().is3Dimension;

        if(is3Dimension)
        {
            transform.position = player3D.position + offset;
        }
        else
        {
            transform.position = player2D.position + offset;
        }
    }
}
