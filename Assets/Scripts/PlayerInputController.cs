using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : GameController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main; //  에임 시스템에 참고하고 나중에 카메라 붙여줄 것
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;  // *정규화*
        CollMoveEvent(moveInput);
    }
    public void OnLook(InputValue value) 
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;
        CollLookEvent(newAim);
    }


}