using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCubeFace : MonoBehaviour
{
    public List<GameObject> lgFaces;
    public int gActiveFace;
    // Start is called before the first frame update
    void Start()
    {
        gActiveFace = 0;
        foreach (var item in lgFaces)
        {
            item.SetActive(false);
        }
        lgFaces[gActiveFace].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeFace(int faceindex)
    {
        foreach (var item in lgFaces)
        {
            item.SetActive(false);
        }
        gActiveFace = faceindex;
        lgFaces[gActiveFace].SetActive(true);
    }
}
