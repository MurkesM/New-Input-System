using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Player;

public class GameInputManager : MonoBehaviour
{
    [SerializeField] Player _player;
    InputActions _input;

    void Start()
    {
        _input = new InputActions();
        _input.Player.Enable();
    }

    void Update()
    {
        Vector2 moveDirection = _input.Player.Movement.ReadValue<Vector2>();
        float rotateDirection = _input.Player.Rotation.ReadValue<float>();
        _player.CalcutateMovement(moveDirection, rotateDirection);
    }
}
