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

    void Awake() // VERY First thing called
    {
        controls = new Controls();
    }

    void OnEnable()
    {
        controls.Enable();

        controls.Gameplay.Shift.performed += ctx => shift = ctx.ReadValue<float>();
        controls.Gameplay.Shift.canceled += ctx => shift = ctx.ReadValue<float>();
        controls.Gameplay.MousePos.performed += OnMouseMove;
    }

    void OnDisable()
    {
        controls.Disable();

        controls.Gameplay.MousePos.performed -= OnMouseMove;
    }

    void Start() //first frame
    {
        
    }

    void Update() //every frame
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
        if(shift > 0)
        {
            Cursor.SetCursor(cursors[1], mousePos, CursorMode.Auto);
        }
        else
        {
            Cursor.SetCursor(cursors[0], mousePos, CursorMode.Auto);
        }
    }
}
