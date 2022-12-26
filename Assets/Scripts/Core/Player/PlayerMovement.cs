using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class PlayerMovement : MonoBehaviour, PlayerInputActions.IPlayerMovementActions
    {
        [Header("Player components")]
        [SerializeField] private Rigidbody2D m_Rigidbody2D;
        [SerializeField] private PlayerBlackboard m_Blackboard;

        private PlayerInputActions m_InputActions;
        private Gamepad m_Gamepad;
        private Keyboard m_Keyboard;

        private Vector3 m_DashStartPosition;
        private Vector3 m_GrabStartPosition;
        private Vector3 m_RopeDirection;
        private Vector3 m_RopeHitPosition;

        private bool m_IsMovementInputPressed;
        private bool m_IsDashActive;
        private bool m_IsRopeGrabActive;
        private bool m_MoveToRopeHitPoint;

        private float m_DashStartTime;
        private float m_DashStartSpeed;

        private float m_RopeGrabStartTime;
        private float m_RopeDistance;
        private float m_RopeStartMovementSpeed;

        private Vector3 m_Direction;
        private Vector3 m_LastDirection;

        [Header("Debug")]
        public Transform m_GrabObject;

        private void Awake()
        {
            m_Keyboard = Keyboard.current;
            m_Gamepad = Gamepad.current;
        }

        private void OnEnable()
        {
            if (m_InputActions == null)
            {
                m_InputActions = new PlayerInputActions();
                m_InputActions.PlayerMovement.SetCallbacks(this);
            }
            m_InputActions.PlayerMovement.Enable();
        }

        private void FixedUpdate()
        {
            Transform l_Transform = transform;
            float l_FixedDeltaTime = Time.fixedDeltaTime;

            Move(l_Transform, l_FixedDeltaTime);
            MoveGrabIfNeeded(l_FixedDeltaTime);
        }

        private void MoveGrabIfNeeded(float deltaTime)
        {
            if(m_IsRopeGrabActive)
            {
                m_Blackboard.m_RopeSpeed += m_Blackboard.m_RopeAcceleration * deltaTime;
                m_RopeDistance += m_Blackboard.m_RopeSpeed * Time.deltaTime;
                // Cast a ray straight down.
                RaycastHit2D hit = Physics2D.Raycast(transform.position, m_RopeDirection, m_RopeDistance, m_Blackboard.m_RopeLayerMask);
                m_GrabObject.position = m_Blackboard.m_RopeSpeed * m_RopeDirection * deltaTime;

                // TODO: Do grab
                // If it hits something...
                if (hit.collider != null)
                {
                    m_RopeDirection = m_Direction;
                    m_RopeHitPosition = hit.point;
                    m_MoveToRopeHitPoint = true;
                    m_RopeStartMovementSpeed = m_Blackboard.m_MovementSpeed;
                }
            }
        }

        private void Move(Transform transform, float deltaTime)
        {
            Vector3 l_CurrentDirection;

            // If player is moving and not moving to rope point then move
            if (IsMovementInputPressed() && !m_MoveToRopeHitPoint)
            {
                if(m_IsDashActive)
                {
                    if(m_Blackboard.m_MovementSpeed < m_DashStartSpeed)
                    {
                        DesactivateDash();
                    }
                    if(Vector3.Distance(transform.position, m_DashStartPosition) < m_Blackboard.m_DashDistance/2)
                    {
                        m_Blackboard.m_MovementSpeed += m_Blackboard.m_DashAcceleration * deltaTime;
                        m_Blackboard.m_MovementSpeed = Mathf.Clamp(m_Blackboard.m_MovementSpeed, 0, m_Blackboard.m_DashMaxMovementSpeed);
                    }
                    else
                    {
                        m_Blackboard.m_MovementSpeed -= m_Blackboard.m_DashDecceleration * deltaTime;
                        m_Blackboard.m_MovementSpeed = Mathf.Clamp(m_Blackboard.m_MovementSpeed, 0, m_Blackboard.m_DashMaxMovementSpeed);
                    }
                }
                else
                {
                    m_Blackboard.m_MovementSpeed += m_Blackboard.m_RunAcceleration * deltaTime;
                    m_Blackboard.m_MovementSpeed = Mathf.Clamp(m_Blackboard.m_MovementSpeed, 0, m_Blackboard.m_RunMaxSpeed);
                }
                l_CurrentDirection = m_Direction;
            }
            else
            {

                m_Blackboard.m_MovementSpeed -= m_Blackboard.m_RunDecceleration * deltaTime;
                m_Blackboard.m_MovementSpeed = Mathf.Clamp(m_Blackboard.m_MovementSpeed, 0, m_Blackboard.m_RunMaxSpeed);
                l_CurrentDirection = m_LastDirection;
            }

            // If player is moving to hit point then 
            if(m_MoveToRopeHitPoint)
            {
                if(Vector2.Distance(transform.position, m_RopeHitPosition) > m_Blackboard.m_RopeTimeToStop)
                {
                    DeactivateGrab();
                }
                m_Blackboard.m_MovementSpeed += m_Blackboard.m_RopeAcceleration * deltaTime;
                m_Blackboard.m_MovementSpeed = Mathf.Clamp(m_Blackboard.m_MovementSpeed, 0, m_Blackboard.m_RunMaxSpeed);
                l_CurrentDirection = m_RopeDirection;
            }

            m_Rigidbody2D.MovePosition(transform.position + m_Blackboard.m_MovementSpeed * l_CurrentDirection * deltaTime);
        }


        private void Dash(float time)
        {
            m_DashStartTime = time + m_Blackboard.m_DashCooldown;
            m_IsDashActive = true;
            m_DashStartSpeed = m_Blackboard.m_MovementSpeed;
            m_DashStartPosition = transform.position;
        }

        private void DesactivateDash()
        {
            m_IsDashActive = false;
            m_DashStartSpeed = 0.0f;
        }

        private void RopeGrab(float time)
        {
            m_RopeGrabStartTime = time + m_Blackboard.m_RopeCooldown;
            m_RopeDistance = 0.0f;
            m_Blackboard.m_RopeSpeed = m_Blackboard.m_MovementSpeed;
            m_GrabObject.position = transform.position;
            m_IsRopeGrabActive = true;
        }

        private void DeactivateGrab()
        {
            m_IsRopeGrabActive = false;
            m_MoveToRopeHitPoint = false;
            m_Blackboard.m_MovementSpeed = IsMovementInputPressed() ? m_RopeStartMovementSpeed : 0.0f;
            m_RopeGrabStartTime = 0.0f;
        }

        private bool IsMovementInputPressed()
        {
            return m_Keyboard.wKey.IsPressed() || m_Keyboard.aKey.IsPressed() ||
                m_Keyboard.dKey.IsPressed() || m_Keyboard.sKey.IsPressed() ||
                m_Gamepad.leftStick.IsPressed();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            m_Direction = context.ReadValue<Vector2>();
            m_Direction.Normalize();

            if (m_Direction != Vector3.zero)
            {
                m_LastDirection = m_Direction;
            }   
        }

        public void OnDash(InputAction.CallbackContext context)
        {
            float l_CurrentTime = Time.time;
            Debug.Log("Dash");
            //TODO: Check to don't call it when realase button
            if (context.ReadValueAsButton() && !m_IsDashActive)
            {
                if (m_DashStartTime <= l_CurrentTime)
                {
                    Dash(l_CurrentTime);
                }
            }
        }

        public void OnGrab(InputAction.CallbackContext context)
        {
            float l_CurrentTime = Time.time;

            //TODO: Check to don't call it when realase button
            //if (context.ReadValueAsButton() && !m_IsRopeGrabActive)
            //{
            //    if (m_RopeGrabStartTime <= l_CurrentTime)
            //    {
            //        Debug.Log("Grab");
            //        RopeGrab(l_CurrentTime);
            //    }
            //}
        }
    }
}

