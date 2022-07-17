using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerInputActions _input;
    Rigidbody _rb;

    void Start()
    {
        _input = new PlayerInputActions();
        _input.Ball.Enable();
        _input.Ball.Bounce.performed += Bounce_performed;
        _input.Ball.Bounce.canceled += Bounce_canceled;

        _rb = GetComponent<Rigidbody>();
    }

    void Bounce_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        double forceOverTime = context.duration;
        _rb.AddForce(Vector3.up * (5 * (float)forceOverTime), ForceMode.Impulse);
    }

    void Bounce_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Jump");
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Fire");
        }

        if (Gamepad.current.aButton.wasPressedThisFrame)
        {
            Debug.Log("Jump");
        }
    }
}