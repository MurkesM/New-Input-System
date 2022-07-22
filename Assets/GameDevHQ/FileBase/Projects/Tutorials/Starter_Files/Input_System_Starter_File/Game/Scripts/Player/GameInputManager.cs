using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.Player;
using Game.Scripts.LiveObjects;

public class GameInputManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] InteractableZone _interactableZone;
    InputActions _input;

    void Start()
    {
        _input = new InputActions();
        _input.Player.Enable();
    }

    void Update()
    {
        HandlePlayerMovement();

        float eButton = _input.Player.InteractableButton1.ReadValue<float>();

        _interactableZone.HandleZoneInteractions(eButton);
    }

    void HandlePlayerMovement()
    {
        float moveXDirection = _input.Player.Movement.ReadValue<Vector3>().x;
        float moveZDirection = _input.Player.Movement.ReadValue<Vector3>().z;
        _player.CalcutateMovement(moveXDirection, moveZDirection);
    }
}