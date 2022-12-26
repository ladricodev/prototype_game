using UnityEngine;
using System.Collections;

namespace Bullets
{
    public class TommyBullet : Bullet
    {
        public void InitializeBullet(int damage, float velocity, Vector3 direction, Vector3 position, float distance)
        {
            transform.position = position;
            m_InitialShootPosition = position;
            m_Damage = damage;
            m_Velocity = velocity;
            m_Direction = direction;
            m_Distance = distance;
            m_Active = true;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Enemy")
            {
                //TODO: Deal damage to enemy
            }
            DestroyBullet();
        }
    }
}


