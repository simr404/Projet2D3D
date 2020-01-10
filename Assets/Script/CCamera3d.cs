using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CCamera3d : MonoBehaviour
{
    public Transform center;
    public Transform player;
    public float height = 4.0f;
    public float offset = 7.0f;

    private void Update()
    {
        cameraMove();
    }
    // la caméra se déplace afin de voir le joueur 
    private void cameraMove()
    {
        Vector3 dir = new Vector3(player.position.x - center.position.x, 0, player.position.z - center.position.z);
        transform.position = dir.normalized * offset + Vector3.up * height;
        transform.LookAt(player);
    }
}
