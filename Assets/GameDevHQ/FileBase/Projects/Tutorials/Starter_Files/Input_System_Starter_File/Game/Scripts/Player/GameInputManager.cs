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
        float moveXDirection = _input.Player.Movement.ReadValue<Vector3>().x;
        float moveZDirection = _input.Player.Movement.ReadValue<Vector3>().z;
        _player.CalcutateMovement(moveXDirection, moveZDirection);
    }
}