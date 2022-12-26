using UnityEngine;
using System.Collections;

namespace Bullets
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class Bullet : MonoBehaviour
    {
        [Header("Bullet components")]
        [SerializeField] private Rigidbody2D m_Rigidbody2D;

        internal int m_Damage;
        internal float m_Distance;
        internal float m_Velocity;
       
        internal Vector3 m_Direction;
        internal Vector3 m_InitialPosition;
        internal Vector3 m_InitialShootPosition;
        internal bool m_Active;

        private void Awake()
        {
            m_InitialPosition = transform.position;
            m_Active = false;
        }

        private void FixedUpdate()
        {
            if (m_Active)
            {
                if (Vector3.Distance(m_InitialShootPosition, transform.position) > m_Distance)
                {
                    DestroyBullet();
                    return;
                }
                m_Rigidbody2D.MovePosition(transform.position + m_Velocity * m_Direction * Time.fixedDeltaTime);
            }
        }

        internal void DestroyBullet()
        {
            transform.position = m_InitialPosition;
            m_Active = false;
        }

        public bool IsActive() { return m_Active; }
    }
}


