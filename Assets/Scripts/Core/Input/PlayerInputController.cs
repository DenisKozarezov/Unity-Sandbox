//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Core/Input/PlayerInputController.inputactions
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

namespace Core.Input
{
    public partial class @PlayerInputController : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInputController()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputController"",
    ""maps"": [
        {
            ""name"": ""Keyboard"",
            ""id"": ""8115b6dd-8951-43fa-911f-bb6db95bac05"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0b006c79-8759-4fc1-9189-1bcb7cdacdba"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""4c321624-cd83-4f8e-91dc-a35f406fabfa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""06fa67b5-9a3a-465b-a80a-5d0bdd876db1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""7ef3c2d4-54da-4896-862b-57fde05bbd0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""2352ea2c-20a1-46c0-9335-1292b140d3c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Spell"",
                    ""type"": ""Button"",
                    ""id"": ""95fa235e-6eae-473a-9874-695a001b0823"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Focus"",
                    ""type"": ""Button"",
                    ""id"": ""526b635b-6969-48a0-8db1-1f0b78f85db8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""f30c41e2-61b0-4f29-a4e4-bd77217ecb97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fcb1f097-a2ac-4e5b-a6b9-7356faa8cf00"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""820f47b5-53a4-4a4d-bfe3-7610aa21a2fd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""29e45367-8ab7-4213-9bb1-64276cee07aa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""60055ac7-d312-4bc0-a70f-6273e20d3af5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5fd9c93a-a308-433d-8991-96756292a743"",
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
                    ""id"": ""3494dab6-adac-4342-9a57-a102192453a4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dedcf1a3-8d57-4ea5-b674-c297a0d75d24"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc65b73a-a5cc-4e8d-b261-5236e3928d5e"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f326f64a-3b33-4aa4-a413-c31c55ea635b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cb670a29-9798-4e43-bb77-f09f7cc5b5ee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9579ef2b-3c51-4148-9da0-df844d5ed399"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7bd331a9-ad3d-47f0-b636-55aaec37a17d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""id"": ""2670bd55-4967-4b5b-a584-53b2e2b05718"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""fd6a6c79-b309-4f31-a949-caa3c3660fb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ec9d642d-2b54-4849-9b59-364801a0efb5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Keyboard
            m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
            m_Keyboard_Move = m_Keyboard.FindAction("Move", throwIfNotFound: true);
            m_Keyboard_Look = m_Keyboard.FindAction("Look", throwIfNotFound: true);
            m_Keyboard_Jump = m_Keyboard.FindAction("Jump", throwIfNotFound: true);
            m_Keyboard_Attack = m_Keyboard.FindAction("Attack", throwIfNotFound: true);
            m_Keyboard_Pause = m_Keyboard.FindAction("Pause", throwIfNotFound: true);
            m_Keyboard_Spell = m_Keyboard.FindAction("Spell", throwIfNotFound: true);
            m_Keyboard_Focus = m_Keyboard.FindAction("Focus", throwIfNotFound: true);
            m_Keyboard_Dash = m_Keyboard.FindAction("Dash", throwIfNotFound: true);
            // Gamepad
            m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
            m_Gamepad_Newaction = m_Gamepad.FindAction("New action", throwIfNotFound: true);
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

        // Keyboard
        private readonly InputActionMap m_Keyboard;
        private IKeyboardActions m_KeyboardActionsCallbackInterface;
        private readonly InputAction m_Keyboard_Move;
        private readonly InputAction m_Keyboard_Look;
        private readonly InputAction m_Keyboard_Jump;
        private readonly InputAction m_Keyboard_Attack;
        private readonly InputAction m_Keyboard_Pause;
        private readonly InputAction m_Keyboard_Spell;
        private readonly InputAction m_Keyboard_Focus;
        private readonly InputAction m_Keyboard_Dash;
        public struct KeyboardActions
        {
            private @PlayerInputController m_Wrapper;
            public KeyboardActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Keyboard_Move;
            public InputAction @Look => m_Wrapper.m_Keyboard_Look;
            public InputAction @Jump => m_Wrapper.m_Keyboard_Jump;
            public InputAction @Attack => m_Wrapper.m_Keyboard_Attack;
            public InputAction @Pause => m_Wrapper.m_Keyboard_Pause;
            public InputAction @Spell => m_Wrapper.m_Keyboard_Spell;
            public InputAction @Focus => m_Wrapper.m_Keyboard_Focus;
            public InputAction @Dash => m_Wrapper.m_Keyboard_Dash;
            public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
            public void SetCallbacks(IKeyboardActions instance)
            {
                if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMove;
                    @Look.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLook;
                    @Jump.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnJump;
                    @Attack.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnAttack;
                    @Pause.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPause;
                    @Spell.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSpell;
                    @Spell.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSpell;
                    @Spell.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnSpell;
                    @Focus.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFocus;
                    @Focus.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFocus;
                    @Focus.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFocus;
                    @Dash.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDash;
                    @Dash.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDash;
                    @Dash.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDash;
                }
                m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                    @Spell.started += instance.OnSpell;
                    @Spell.performed += instance.OnSpell;
                    @Spell.canceled += instance.OnSpell;
                    @Focus.started += instance.OnFocus;
                    @Focus.performed += instance.OnFocus;
                    @Focus.canceled += instance.OnFocus;
                    @Dash.started += instance.OnDash;
                    @Dash.performed += instance.OnDash;
                    @Dash.canceled += instance.OnDash;
                }
            }
        }
        public KeyboardActions @Keyboard => new KeyboardActions(this);

        // Gamepad
        private readonly InputActionMap m_Gamepad;
        private IGamepadActions m_GamepadActionsCallbackInterface;
        private readonly InputAction m_Gamepad_Newaction;
        public struct GamepadActions
        {
            private @PlayerInputController m_Wrapper;
            public GamepadActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_Gamepad_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
            public void SetCallbacks(IGamepadActions instance)
            {
                if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
                {
                    @Newaction.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnNewaction;
                    @Newaction.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnNewaction;
                    @Newaction.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnNewaction;
                }
                m_Wrapper.m_GamepadActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Newaction.started += instance.OnNewaction;
                    @Newaction.performed += instance.OnNewaction;
                    @Newaction.canceled += instance.OnNewaction;
                }
            }
        }
        public GamepadActions @Gamepad => new GamepadActions(this);
        public interface IKeyboardActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnSpell(InputAction.CallbackContext context);
            void OnFocus(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
        }
        public interface IGamepadActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
    }
}
