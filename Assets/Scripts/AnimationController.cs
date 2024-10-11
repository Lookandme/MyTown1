using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AnimationController : MonoBehaviour
{
    protected  Animator animator;
    protected  GameController controller;

    protected virtual void Awake()
    {
        controller = GetComponent<GameController>();
        animator = GetComponent<Animator>();
        
       
    }
}
