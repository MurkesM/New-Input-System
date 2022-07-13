using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    PlayerInputActions _input;

    void Start()
    {
        _input = new PlayerInputActions();
        _input.Player.Enable();
        _input.Player.Movement.performed += Movement_performed;
    }

    private void Movement_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Movement");
    }
}
