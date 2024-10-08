using System;
using UnityEngine;

public class GameMoveMent : MonoBehaviour
{
    private GameController controller;
    private Rigidbody2D movement;
    private Vector2 movementDir = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<GameController>();
        movement = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDir);
    }
    private void Move(Vector2 dir)
    {
        movementDir = dir;
    }

    private void ApplyMovement(Vector2 dir)
    {
        dir = dir * 5;
        movement.velocity = dir;
    }
}