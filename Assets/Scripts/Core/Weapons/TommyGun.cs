using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;
using Bullets;

namespace Weapons
{
    public class TommyGun : Weapon
    {
        [SerializeField] private WeaponSO m_TommyAttributes;
        [SerializeField] private Vector2 m_DirectionOffset = new Vector2(-0.2f, 0.2f);

        private float m_LastBulletStartTime;


        public override void Fire(Vector3 direction)
        {
            if(m_LastBulletStartTime < Time.time)
            {
                TommyBullet m_Bullet = PoolManager.Instance.GetTommyBullet();
                Vector3 l_Direction = GetRandomDirection(direction);
                WeaponAttributes l_Attributes = m_TommyAttributes.m_WeaponLevel[m_Level];
                m_LastBulletStartTime = Time.time + l_Attributes.m_FireRate;
                m_Bullet.InitializeBullet(l_Attributes.m_Damage, l_Attributes.m_BulletVelocity, l_Direction, m_CannonTransform.position,l_Attributes.m_Distance);
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


