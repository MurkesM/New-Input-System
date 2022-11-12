using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Game.Scripts.Player;

public class PlayerInputManager : MonoBehaviour
{
    [SerializeField] Player _player;
    PlayerInputs _inputActions;

    Vector2 _moveDirection = new();

    void Start()
    {
        _inputActions = new();
        _inputActions.Player.Enable();
    }

    void Update()
    {
        CalculatePlayerMovement();
    }

    void CalculatePlayerMovement()
    {
        _moveDirection = _inputActions.Player.Movement.ReadValue<Vector2>();
        _player.CalcutateMovement(_moveDirection);
    }
}