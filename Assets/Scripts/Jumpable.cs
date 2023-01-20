using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jumpable : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

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

    private void OnMouseLeftButtonClicked()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Force);
    }
}
