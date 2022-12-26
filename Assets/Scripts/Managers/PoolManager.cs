using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using Bullets;

public class PoolManager : Singleton<PoolManager>
{
    [SerializeField] private List<TommyBullet> m_TommyGunBullets;
    [SerializeField] private List<Rocket> m_Rockets;
    [SerializeField] private List<ShotgunBullet> m_ShotgunBullets;


    public TommyBullet GetTommyBullet()
    {
        foreach (TommyBullet bullet in m_TommyGunBullets)
        {
            if (!bullet.IsActive()) return bullet;
        }

        Debug.LogError("Not enought bullets in pool");
        return null;
    }

    public Rocket GetRocket()
    {
        foreach (Rocket rocket in m_Rockets)
        {
            if (!rocket.IsActive()) return rocket;
        }

        Debug.LogError("Not enought bullets in pool");
        return null;
    }

    public ShotgunBullet GetShotgunBullet()
    {
        foreach (ShotgunBullet bullet in m_ShotgunBullets)
        {
            if (!bullet.IsActive()) return bullet;
        }

        Debug.LogError("Not enought bullets in pool");
        return null;
    }
}
