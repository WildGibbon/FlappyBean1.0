using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatable : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private Quaternion _maxRotation;
    [SerializeField] private Quaternion _minRotation;
    [SerializeField] private float _rotationSpeed;

    private void OnEnable()
    {
        if (_input != null)
        {
			_input.MouseLeftButtonClicked += OnMouseLeftButtonClicked;
        }
    }

    private void OnDisable()
    {
        if (_input != null)
        {
            _input.MouseLeftButtonClicked -= OnMouseLeftButtonClicked;
        }
    }

    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
    }

    private void OnMouseLeftButtonClicked()
    {
        transform.rotation = _maxRotation;
    }
}
