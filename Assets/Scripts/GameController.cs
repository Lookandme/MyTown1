using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;


    public void CollMoveEvent(Vector2 dir)
    {
        OnMoveEvent?.Invoke(dir);
    }
    public void CollLookEvent(Vector2 dir) 
    {
        OnLookEvent?.Invoke(dir);
    }

}
