using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerWeaponController : MonoBehaviour, PlayerInputActions.IPlayerFireActions
    {
        [SerializeField] private PlayerBlackboard m_Blackboard;
        [SerializeField] private float m_RotationSpeed;

        private PlayerInputActions m_InputActions;
        private Gamepad m_Gamepad;
        private Keyboard m_Keyboard;
        private Vector2 m_Direction;

        private bool m_ShootWeaponLeft;
        private bool m_ShootWeaponRight;

        private void Awake()
        {
            m_Keyboard = Keyboard.current;
            m_Gamepad = Gamepad.current;

            m_ShootWeaponLeft = false;
            m_ShootWeaponRight = false;
        }

        private void OnEnable()
        {
            if (m_InputActions == null)
            {
                m_InputActions = new PlayerInputActions();
                m_InputActions.PlayerFire.SetCallbacks(this);
            }
            m_InputActions.PlayerFire.Enable();
        }

        private void Update()
        {
            if(m_ShootWeaponLeft) ShootWeaponLeft();
            if (m_ShootWeaponRight) ShootWeaponRight();
          
        }

        private void RotateToDirection(Vector3 direction)
        {
            if(direction != Vector3.zero)
            {
                var l_AngleToRotate = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
                m_Blackboard.m_WeaponOneEquipped.transform.rotation = Quaternion.AngleAxis(-l_AngleToRotate, Vector3.forward);
                m_Blackboard.m_WeaponTwoEquiped.transform.rotation = Quaternion.AngleAxis(-l_AngleToRotate, Vector3.forward);
            }
        }

        internal void ShootWeaponLeft()
        {
            m_Blackboard.m_WeaponOneEquipped.Fire(m_Direction);
        }

        internal void ShootWeaponRight()
        {
            m_Blackboard.m_WeaponTwoEquiped.Fire(m_Direction);
        }


        public void OnFireLeft(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                m_ShootWeaponLeft = true;
            }
            else if (context.canceled)
            {
                m_ShootWeaponLeft = false;
            }
          
        }

        public void OnFireRight(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                m_ShootWeaponRight = true;
            }
            else if (context.canceled)
            {
                m_ShootWeaponRight = false;
            }
        }

        public void OnAim(InputAction.CallbackContext context)
        {
            m_Direction = context.ReadValue<Vector2>();
            RotateToDirection(m_Direction);
        }
    }
}

