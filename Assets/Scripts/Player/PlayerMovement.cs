using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.Set(InputManager.Movement.x, InputManager.Movement.y);

        //you dont need to multiply this by time.deltatime
        //nor do you need it in fixedupdate because the speed is set, and it will be the same regardless of framerate
        rb.velocity = movement * moveSpeed;
    }
}
