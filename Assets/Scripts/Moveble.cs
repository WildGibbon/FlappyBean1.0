using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveble : MonoBehaviour
{
    [SerializeField] private Vector3 _moveDirection;
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.Translate(_moveDirection.normalized * _moveSpeed * Time.deltaTime, Space.World);
    }
}
