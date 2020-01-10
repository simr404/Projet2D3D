using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CThirdPersonCamera : MonoBehaviour
{
    public float m_fRotationSpeed;
    public Transform m_tTarget, m_tPlayer;
    public Vector2 m_v2ClampMouseY;

    private float m_fMouseX, m_fMouseY;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CameraMovement();
    }

    private void CameraMovement()
    {
        m_fMouseX += Input.GetAxis("Mouse X") * m_fRotationSpeed;
        m_fMouseY -= Input.GetAxis("Mouse Y") * m_fRotationSpeed;
        m_fMouseY = Mathf.Clamp(m_fMouseY, m_v2ClampMouseY.x, m_v2ClampMouseY.y);

        transform.LookAt(m_tTarget);

        m_tTarget.rotation = Quaternion.Euler(m_fMouseY, m_fMouseX, 0);
        m_tPlayer.rotation = Quaternion.Euler(0, m_fMouseX, 0);
    }
}
