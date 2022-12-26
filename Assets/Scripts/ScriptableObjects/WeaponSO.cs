using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapons", menuName = "Weapon/New Weapon", order = 1)]
public class WeaponSO : ScriptableObject
{
    [Tooltip("The number of levels that the weapon will have")]
    [Header("Number of level that weapon have")]
    public List<WeaponAttributes> m_WeaponLevel;                                  // List of levels that weapon have
}

[System.Serializable]
public class WeaponAttributes
{
    [Tooltip("Bullet force only used in granade explosion to apply force to RB")]
    public float m_BulletVelocity;
    public float m_FireRate;
    public int m_Distance;
    public int m_Damage;
    public int m_Ammo;
    public float m_Radius;
    //TODO: Add upgrade cost or experience to upgrade
}