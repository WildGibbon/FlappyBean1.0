using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public event Action MouseLeftButtonClicked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseLeftButtonClicked?.Invoke();
        }
    }
}
