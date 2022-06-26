// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""09157c0f-15c7-4c14-a9eb-5828b86df79e"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""be699053-78c7-4f19-94ff-38b75fffbbe6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""07272480-7a48-4c89-a6e0-01f3b7dfd203"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""125d5d77-92ab-499c-8806-bfe156fe3f4f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeleteShortcut"",
                    ""type"": ""Button"",
                    ""id"": ""f106530c-65b4-4466-937d-9e7b3f0d48fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shift"",
                    ""type"": ""Button"",
                    ""id"": ""9544fe3c-8ebd-48ce-8b9f-093c62e4776d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alt"",
                    ""type"": ""Button"",
                    ""id"": ""505e66e2-dad5-4735-a0cc-81033d6c264b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""901c7562-2d71-4cbb-87c4-e3cb2f9cb689"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""905d64bc-4605-4727-b2f3-877bb96b550b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""998da95d-0a71-4f4f-8888-ccc79f16a056"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""48a92b15-95ab-486d-b9b2-96ccff26efd0"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeleteShortcut"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""5db6958a-f963-4e03-ab49-f2358c777ea9"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeleteShortcut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""b310743c-c78d-47c6-a6ff-492aad01d13b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeleteShortcut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3eeeb1c6-8275-4848-86cd-a2bd01d72d67"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15de432c-2873-4f07-b6e1-016e199c3fea"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_LeftClick = m_Gameplay.FindAction("LeftClick", throwIfNotFound: true);
        m_Gameplay_RightClick = m_Gameplay.FindAction("RightClick", throwIfNotFound: true);
        m_Gameplay_MousePos = m_Gameplay.FindAction("MousePos", throwIfNotFound: true);
        m_Gameplay_DeleteShortcut = m_Gameplay.FindAction("DeleteShortcut", throwIfNotFound: true);
        m_Gameplay_Shift = m_Gameplay.FindAction("Shift", throwIfNotFound: true);
        m_Gameplay_Alt = m_Gameplay.FindAction("Alt", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_LeftClick;
    private readonly InputAction m_Gameplay_RightClick;
    private readonly InputAction m_Gameplay_MousePos;
    private readonly InputAction m_Gameplay_DeleteShortcut;
    private readonly InputAction m_Gameplay_Shift;
    private readonly InputAction m_Gameplay_Alt;
    public struct GameplayActions
    {
        private @Controls m_Wrapper;
        public GameplayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Gameplay_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Gameplay_RightClick;
        public InputAction @MousePos => m_Wrapper.m_Gameplay_MousePos;
        public InputAction @DeleteShortcut => m_Wrapper.m_Gameplay_DeleteShortcut;
        public InputAction @Shift => m_Wrapper.m_Gameplay_Shift;
        public InputAction @Alt => m_Wrapper.m_Gameplay_Alt;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
                @MousePos.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMousePos;
                @DeleteShortcut.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDeleteShortcut;
                @DeleteShortcut.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDeleteShortcut;
                @DeleteShortcut.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDeleteShortcut;
                @Shift.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift;
                @Shift.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift;
                @Shift.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShift;
                @Alt.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAlt;
                @Alt.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAlt;
                @Alt.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAlt;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
                @DeleteShortcut.started += instance.OnDeleteShortcut;
                @DeleteShortcut.performed += instance.OnDeleteShortcut;
                @DeleteShortcut.canceled += instance.OnDeleteShortcut;
                @Shift.started += instance.OnShift;
                @Shift.performed += instance.OnShift;
                @Shift.canceled += instance.OnShift;
                @Alt.started += instance.OnAlt;
                @Alt.performed += instance.OnAlt;
                @Alt.canceled += instance.OnAlt;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
        void OnDeleteShortcut(InputAction.CallbackContext context);
        void OnShift(InputAction.CallbackContext context);
        void OnAlt(InputAction.CallbackContext context);
    }
}
