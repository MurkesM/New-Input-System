using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float _speed = 3;

    void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }
}