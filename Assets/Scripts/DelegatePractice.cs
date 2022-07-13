using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatePractice : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void ButtonClick()
    {
        if (onClick != null)
            onClick();
    }
}
