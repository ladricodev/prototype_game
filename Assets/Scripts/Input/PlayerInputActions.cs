//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""03f2c6ca-a16e-437c-8210-d3ad02dde314"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5f05398e-3732-429d-9975-2a47372d21dd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""8b5fbe11-7384-46c3-9d46-11173b10b1a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""14b0091b-f18d-4e22-ade1-c191964ea244"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fa75be74-41c3-470a-9f96-a06496f50309"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fe77dba7-7180-49e0-883f-2eca315177cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f87e15c2-be69-46a6-b411-519c6c463cd1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6fe3d6a0-fe63-4897-9175-4d0866669490"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""89fa0baf-0d36-45a6-9215-971d2a824e81"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bbe6aa8d-f2bc-47da-bdd8-97652e41c7f2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=1,max=1),Scale"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c81e629-c2c7-44b2-8e82-71fda758ea98"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4c58735-b289-49d1-aba1-6e37c6478bed"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bd4cb51-bd30-40f0-813b-9733780c0392"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9874b94e-a101-4ac6-9a3f-983ed3c4b3d4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerFire"",
            ""id"": ""fc3d30cd-c717-44d9-82b7-34a334b34ce3"",
            ""actions"": [
                {
                    ""name"": ""FireLeft"",
                    ""type"": ""Button"",
                    ""id"": ""608287cc-38e7-43e1-bb3e-dd108317704e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FireRight"",
                    ""type"": ""Button"",
                    ""id"": ""c0922c02-ea5f-405a-bb71-c999db67d686"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""34affa99-a13e-499b-bf66-8a5629f61a72"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""008f5cfd-24c0-4335-8c2f-c3d0e9951644"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a15daa18-134d-4a8e-9280-59251fee749a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3931bd94-140b-41b6-9463-733d88f616e7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2beff4b-d69b-4391-a994-fc5f458b880d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8dd1227-6d93-47fd-9079-be6b3de47687"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=1,max=1),Scale"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Move = m_PlayerMovement.FindAction("Move", throwIfNotFound: true);
        m_PlayerMovement_Dash = m_PlayerMovement.FindAction("Dash", throwIfNotFound: true);
        m_PlayerMovement_Grab = m_PlayerMovement.FindAction("Grab", throwIfNotFound: true);
        // PlayerFire
        m_PlayerFire = asset.FindActionMap("PlayerFire", throwIfNotFound: true);
        m_PlayerFire_FireLeft = m_PlayerFire.FindAction("FireLeft", throwIfNotFound: true);
        m_PlayerFire_FireRight = m_PlayerFire.FindAction("FireRight", throwIfNotFound: true);
        m_PlayerFire_Aim = m_PlayerFire.FindAction("Aim", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Move;
    private readonly InputAction m_PlayerMovement_Dash;
    private readonly InputAction m_PlayerMovement_Grab;
    public struct PlayerMovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerMovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMovement_Move;
        public InputAction @Dash => m_Wrapper.m_PlayerMovement_Dash;
        public InputAction @Grab => m_Wrapper.m_PlayerMovement_Grab;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Dash.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnDash;
                @Grab.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnGrab;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // PlayerFire
    private readonly InputActionMap m_PlayerFire;
    private IPlayerFireActions m_PlayerFireActionsCallbackInterface;
    private readonly InputAction m_PlayerFire_FireLeft;
    private readonly InputAction m_PlayerFire_FireRight;
    private readonly InputAction m_PlayerFire_Aim;
    public struct PlayerFireActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerFireActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @FireLeft => m_Wrapper.m_PlayerFire_FireLeft;
        public InputAction @FireRight => m_Wrapper.m_PlayerFire_FireRight;
        public InputAction @Aim => m_Wrapper.m_PlayerFire_Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerFire; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerFireActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerFireActions instance)
        {
            if (m_Wrapper.m_PlayerFireActionsCallbackInterface != null)
            {
                @FireLeft.started -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnFireLeft;
                @FireLeft.performed -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnFireLeft;
                @FireLeft.canceled -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnFireLeft;
                @FireRight.started -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnFireRight;
                @FireRight.performed -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnFireRight;
                @FireRight.canceled -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnFireRight;
                @Aim.started -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerFireActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_PlayerFireActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FireLeft.started += instance.OnFireLeft;
                @FireLeft.performed += instance.OnFireLeft;
                @FireLeft.canceled += instance.OnFireLeft;
                @FireRight.started += instance.OnFireRight;
                @FireRight.performed += instance.OnFireRight;
                @FireRight.canceled += instance.OnFireRight;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public PlayerFireActions @PlayerFire => new PlayerFireActions(this);
    public interface IPlayerMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
    }
    public interface IPlayerFireActions
    {
        void OnFireLeft(InputAction.CallbackContext context);
        void OnFireRight(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
}
