using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bullets;

namespace Weapons
{
    public class RocketLauncher : Weapon
    {
        [SerializeField] private WeaponSO m_TommyAttributes;
        [SerializeField] private Vector2 m_DirectionOffset = new Vector2(-0.2f, 0.2f);

        private float m_LastBulletStartTime;


        public override void Fire(Vector3 direction)
        {
            if (m_LastBulletStartTime < Time.time)
            {
                WeaponAttributes l_Attributes = m_TommyAttributes.m_WeaponLevel[m_Level];

                Rocket m_Bullet = PoolManager.Instance.GetRocket();
                Vector3 l_Direction = GetRandomDirection(direction);
                
                m_LastBulletStartTime = Time.time + l_Attributes.m_FireRate;
                m_Bullet.InitializeBullet(l_Attributes.m_Damage, l_Attributes.m_BulletVelocity, l_Direction, m_CannonTransform.position, l_Attributes.m_Distance, l_Attributes.m_Radius);
            }
        }

        private Vector3 GetRandomDirection(Vector3 direction)
        {
            float l_Offset = Random.Range(m_DirectionOffset.x, m_DirectionOffset.y);
            direction.x += l_Offset;
            return direction;
        }
    }
}

