using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons;

namespace Player
{
    public class PlayerBlackboard : MonoBehaviour
    {
        [Header("Run attributes")]
        [SerializeField] internal float m_RunAcceleration;
        [SerializeField] internal float m_RunDecceleration;
        [SerializeField] internal float m_RunMaxSpeed;

        [Header("Rope attributes")]
        [SerializeField] internal float m_RopeCooldown;
        [SerializeField] internal float m_RopeAcceleration;
        [SerializeField] internal float m_RopeDecceleration;
        [SerializeField] internal float m_RopeTimeToStop;
        [SerializeField] internal float m_RopeGrabMaxSpeed;
        [SerializeField] internal LayerMask m_RopeLayerMask;

        [Header("Dash attributes")]
        [SerializeField] internal float m_DashCooldown;
        [SerializeField] internal float m_DashDistance;
        [SerializeField] internal float m_DashMaxMovementSpeed;
        [SerializeField] internal float m_DashAcceleration;
        [SerializeField] internal float m_DashDecceleration;

        [Header("Weapons")]
        [SerializeField] internal Weapon m_WeaponOneEquipped;
        [SerializeField] internal Weapon m_WeaponTwoEquiped;

        [Header("Debug")]
        [SerializeField] internal float m_MovementSpeed;
        [SerializeField] internal float m_RopeSpeed;

       
    }
}

