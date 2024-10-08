using System;
using UnityEngine;

public class PlayerGaze : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderdr;

    private GameController controller;

    private void Awake()
    {
        controller = GetComponent<GameController>();
    }
    private void Start()
    {
        controller.OnLookEvent += OnGaze;
    }

    private void OnGaze(Vector2 dir)
    {
        RotationGaze(dir);
    }

    private void RotationGaze(Vector2 dir)
    {
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        characterRenderdr.flipX = Mathf.Abs(rotZ) > 90f;
    }
}