using UnityEngine;
using System.Collections;
using Bullets;
using System.Collections.Generic;

namespace Weapons
{
    public class Shotgun : Weapon
    {
        [SerializeField] int m_BulletsToShoot = 5;
        public override void Fire(Vector3 direction)
        {
            List<ShotgunBullet> m_ShotgunBullets;

            ////TODO: Spread bullets in certain distance
            //for (int i = 0; i < m_BulletsToShoot; i++)
            //{
            //    m_ShotgunBullets.Add(PoolManager.Instance.GetShotgunBullet());
            //}
        }
    }
}

