using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    PlayerInputActions _input;
    [SerializeField] Slider _slider;
    bool _isFilling;

    void Start()
    {
        _input = new PlayerInputActions();
        _input.Bar.Enable();
        _input.Bar.Fill.started += Fill_started;
        _input.Bar.Fill.canceled += Fill_canceled;
    }

    void Fill_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _isFilling = true;
        StartCoroutine(ProgressBarRoutine());
    }

    void Fill_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        _isFilling = false;
    }

    IEnumerator ProgressBarRoutine()
    {
        while (_isFilling == true)
        {
            _slider.value += Time.deltaTime;
            yield return null;
        }

        while (_isFilling == false)
        {
            _slider.value -= Time.deltaTime;
            yield return null;
        }
    }
}