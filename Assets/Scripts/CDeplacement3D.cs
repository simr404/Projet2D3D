using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CDeplacement3D : MonoBehaviour
{
    private Rigidbody m_rbRigidBody;
    private float m_fX, m_fY, m_fZ, m_fJumpVelocity;
    private Vector3 m_v3RayOrigin, m_v3RayDirection;
    private RaycastHit m_rhHitInfo;
    private bool m_bIsGrounded;

    public float m_fMoveSpeed;
    public float m_fJumpForce;
    public float m_fJumpDist;
    
    public float m_fSizeRay;

    public LayerMask m_lmGroundMask;

    void Start()
    {
        m_rbRigidBody = GetComponent<Rigidbody>();
        m_v3RayDirection = Vector3.down;
    }

    void Update()
    {
        m_bIsGrounded = IsGrounded();
        m_v3RayOrigin = transform.position;// + new Vector3(0, m_fSizeRay, 0);

        m_fX = Input.GetAxis("Horizontal");
        m_fY = Jump();
        m_fZ = Input.GetAxis("Vertical");

        Movement(m_fX, m_fY, m_fZ);
        Debug.DrawRay(m_v3RayOrigin, m_v3RayDirection * m_fSizeRay, Color.green, 0.1f);
    }

    private float Jump()
    {
        m_fJumpVelocity = 0;
        
        if (m_bIsGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                m_fJumpVelocity = m_fJumpForce * m_fMoveSpeed;
            }    
        }
        else
        {
            m_fJumpVelocity = -m_fJumpForce/2.3f;
        }      

        return m_fJumpVelocity;
    }

    private bool IsGrounded()
    {
        if (Physics.Raycast(m_v3RayOrigin, m_v3RayDirection, out m_rhHitInfo, m_fSizeRay))
        {
            float distance = transform.position.sqrMagnitude - m_rhHitInfo.point.sqrMagnitude;
            //Debug.Log(distance);
            if (distance <= m_fJumpDist)
            {
                return true;
            }

            return false;
        }
        
        return false;
    }

    private void Movement(float X, float Y, float Z)
    {
        Vector3 newPosition = new Vector3(X, 0, Z);
        m_rbRigidBody.velocity = newPosition * m_fMoveSpeed + Vector3.up * Y;
    }
}
