using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothFollow : MonoBehaviour
{
    [SerializeField] private Transform m_Target;
    [SerializeField] private Vector3 m_Offset;
    [SerializeField][Range(0.01f, 1f)] private float m_SmoothSpeed = 0.125f;

    private Vector3 m_Velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 l_DesiredPosition = m_Target.position + m_Offset;
        transform.position = Vector3.SmoothDamp(transform.position, l_DesiredPosition, ref m_Velocity, m_SmoothSpeed);
    }
}
