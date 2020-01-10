using UnityEngine;

public class CQuitCube : MonoBehaviour
{
    //Author : Rinalduzzi


    public GameObject m_Player2D;//reference to the 2D sprite character
    public GameObject m_Player3D;//reference to the 3D character

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == m_Player2D.name)//verify that the object who triggered the hitbox is the player
        {
            m_Player2D.gameObject.SetActive(false);
            m_Player3D.gameObject.SetActive(true);
        }
    }

 

}
