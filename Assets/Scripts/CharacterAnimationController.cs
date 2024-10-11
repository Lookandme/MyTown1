using System;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int MoveUP = Animator.StringToHash("MoveUp");
    private static readonly int MoveDown = Animator.StringToHash("MoveDown");
    private static readonly int MoveLeft = Animator.StringToHash("MoveLeft");
    private static readonly int MoveRight = Animator.StringToHash("MoveRight");

    private readonly float magnituteThreshold = 0.5f;



    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        bool isMovingUp = obj.y > magnituteThreshold;
        bool isMovingDown = obj.y < -magnituteThreshold;
        bool isMovingLeft = obj.x < -magnituteThreshold;
        bool isMovingRight = obj.x > magnituteThreshold;
        

       
        animator.SetBool(MoveUP,isMovingUp);
        animator.SetBool(MoveDown,isMovingDown);
        animator.SetBool(MoveLeft,isMovingLeft);
        animator.SetBool(MoveRight,isMovingRight);
        
    }
}