using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    Controls controls;
    Vector2 _mousePos;
    Vector2 mousePos;

    float shift;

    public Texture2D[] cursors;

    void Awake()
    {
        controls = new Controls();
    }

    void OnEnable()
    {
        controls.Enable();

        controls.Gameplay.MousePos.performed += OnMouseMove;
    }

    void OnDisable()
    {
        controls.Disable();

        controls.Gameplay.MousePos.performed -= OnMouseMove;
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(_mousePos);
    }

    void FixedUpdate()
    {
        OnShift();
    }

    private void OnMouseMove(InputAction.CallbackContext ctx)
    {
        _mousePos = ctx.ReadValue<Vector2>();
    }

    void OnShift()
    {
        if(Keyboard.current.shiftKey.isPressed)
        {
            Cursor.SetCursor(cursors[1], mousePos, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(cursors[0], mousePos, CursorMode.Auto);
        }
    }
}
