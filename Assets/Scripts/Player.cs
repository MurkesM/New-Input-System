using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject _projectilePrefab;
    float _speed = 10;

    public void Movement(Vector2 _direction)
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void Fire()
    {
        Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
    }
}