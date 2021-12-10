using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseFollow : MonoBehaviour
{
    Controls playerInput;
    Vector2 mousePos;
    public Vector3 offset;

    void Awake()
    {
        playerInput = new Controls();
    }

    void FixedUpdate()
    {
        transform.position = Camera.main.ScreenToWorldPoint(mousePos) + offset;
        //Cursor.visible = false;
    }

    private void OnEnable()
    {
        playerInput.Enable();

        playerInput.Gameplay.MousePos.performed += OnMouseMove;
    }

    private void OnDisable()
    {
        playerInput.Disable();

        playerInput.Gameplay.MousePos.performed -= OnMouseMove;
    }

    private void OnMouseMove(InputAction.CallbackContext ctx)
    {
        mousePos = ctx.ReadValue<Vector2>();
    }
}
