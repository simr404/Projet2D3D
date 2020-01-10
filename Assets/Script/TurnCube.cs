using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCube : MonoBehaviour
{
    Vector3 VRotate;
    public GameObject Cube;
    public enum TurnMap { Right, Left};
    public TurnMap TurnMovement;
    Quaternion QDesiredRot;
    public int iTurnToFace;
    public GameObject Player;
    Vector3 V3PlayerPos;
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
        V3PlayerPos = Player.transform.position;
        if (TurnMovement == TurnMap.Left)
        {
            StartCoroutine(Rotate(Vector3.down, 90, 0.5f));
        }
        else if (TurnMovement == TurnMap.Right)
        {
            StartCoroutine(Rotate(Vector3.up, 90, 0.5f));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Turn();
        }
    }

    IEnumerator Rotate(Vector3 axis, float angle, float duration = 1.0f)
    {
        Quaternion from = Cube.transform.rotation;
        Quaternion to = Cube.transform.rotation;
        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            Cube.transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        Cube.transform.rotation = to;
        Cube.GetComponent<CCubeFace>().ChangeFace(iTurnToFace);
        Player.transform.position = V3PlayerPos - new Vector3(axis.y, 0);
        Player.transform.Rotate(new Vector3(0, 90));
    }

}
