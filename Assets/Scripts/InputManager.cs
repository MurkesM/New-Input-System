using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Player _player;
    InputActions _input;

    void Start()
    {
        _input = new InputActions();
        _input.Player.Enable();

        _input.Player.Fire.performed += Fire_performed;
    }

    void Update()
    {
        Vector2 moveDirection = _input.Player.Movement.ReadValue<Vector2>();
        _player.Movement(moveDirection);
    }

    void Fire_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _player.Fire();
    }
}