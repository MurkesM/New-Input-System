using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatePractice : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void ButtonClick() //is the method called by the button
    {
        if (onClick != null)
            onClick();
    }
}
