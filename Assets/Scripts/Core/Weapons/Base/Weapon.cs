using UnityEngine;
using System.Collections;

namespace Weapons
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] internal Transform m_CannonTransform;
        [SerializeField] internal WeaponSO m_Attributes;
        internal int m_Level;

        public abstract void Fire(Vector3 direction);
    }
}

