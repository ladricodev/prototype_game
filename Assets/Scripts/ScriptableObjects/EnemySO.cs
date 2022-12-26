using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemies", menuName = "Enemy/New Enemy", order = 2)]
public class EnemySO : ScriptableObject
{
    [Tooltip("The number of levels that the weapon will have")]
    [Header("Number of level that weapon have")]
    public List<EnemyAttributes> m_WeaponLevel;                                  // List of levels that weapon have
}

[System.Serializable]
public class EnemyAttributes
{
    [Tooltip("Bullet force only used in granade explosion to apply force to RB")]
    public float m_Damage;
    public float m_Speed;
    public int m_MaxHP;
}