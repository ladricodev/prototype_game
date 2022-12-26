using UnityEngine;
using System.Collections;

namespace Bullets
{
    public class Rocket : Bullet
    {
        internal float m_Radius;

        public void InitializeBullet(int damage, float velocity, Vector3 direction, Vector3 position, float distance, float radius)
        {
            transform.position = position;
            m_InitialShootPosition = position;
            m_Damage = damage;
            m_Velocity = velocity;
            m_Direction = direction;
            m_Distance = distance;
            m_Active = true;
            m_Radius = radius;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            ExplosionDamage(collision.transform.position, m_Radius);
            DestroyBullet();
        }

        void ExplosionDamage(Vector3 center, float radius)
        {
            Collider[] hitColliders = Physics.OverlapSphere(center, radius);
            foreach (var hitCollider in hitColliders)
            {
                //TODO Deal damage to all enemies and destroy objects in the scenario
            }
        }
    }
} 


