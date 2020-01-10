using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnterCube : MonoBehaviour
{
    //Author : Rinalduzzi


    public GameObject m_Player2D;//reference to the 2D sprite character
    public GameObject m_Player3D;//reference to the 3D character

    private void Start()
    {
        m_Player2D.SetActive(false);
        m_Player3D.SetActive(true);        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == m_Player3D.name)//verify that the object who triggered the hitbox is the player
        {
            m_Player3D.gameObject.SetActive(false);
            m_Player2D.gameObject.SetActive(true);
        }
    }


}
