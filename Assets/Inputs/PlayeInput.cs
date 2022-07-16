using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayeInput : MonoBehaviour
{
    PlayerInputActions _input;
    float _rotateDirection;
    Vector2 _moveDirection;

    void Start()
    {
        _input = new PlayerInputActions();
        _input.Player.Enable();
        _input.Player.ColorChange.performed += ColorChange_performed;
        _input.Player.Drive.performed += Drive_performed;
        _input.Driving.StopDriving.performed += StopDriving_performed;
    }

    void StopDriving_performed(InputAction.CallbackContext context)
    {
        _input.Player.Enable();
        _input.Driving.Disable();
    }

    void Drive_performed(InputAction.CallbackContext context)
    {
        _input.Player.Disable();
        _input.Driving.Enable();
    }

    void ColorChange_performed(InputAction.CallbackContext context)
    {
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }

    void Update()
    {
        _rotateDirection = _input.Player.Rotate.ReadValue<float>();
        transform.Rotate(Vector3.down * Time.deltaTime * 30 * _rotateDirection);

        _moveDirection = _input.Driving.Movement.ReadValue<Vector2>();
        transform.Translate(_moveDirection * Time.deltaTime * 30);
    }
}