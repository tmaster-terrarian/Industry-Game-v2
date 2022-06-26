using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;
    [SerializeField][Range(0,1)] float movementSmoothing;

    public bool collisionsEnabled = true;

    Rigidbody2D rb;
    BoxCollider2D hitbox;
    Vector2 targetDir;
    Vector2 currentDir;
    Vector2 currentDirVelocity;
    Keyboard keyboard;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hitbox = GetComponent<BoxCollider2D>();
        keyboard = Keyboard.current;
    }

    void Update()
    {
        targetDir = new Vector2(keyboard.dKey.ReadValue() - keyboard.aKey.ReadValue(), keyboard.wKey.ReadValue() - keyboard.sKey.ReadValue());
        targetDir.Normalize();

        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, movementSmoothing);

        Vector3 velocity = (transform.up * currentDir.y + transform.right * currentDir.x) * moveSpeed;
        rb.MovePosition(transform.position + velocity * Time.unscaledDeltaTime);

        if(!collisionsEnabled)
        {
            hitbox.isTrigger = true;
        }
        else hitbox.isTrigger = false;
    }
}
