using System;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    private int _value;

    public event UnityAction<int> ValueChanged;

    public void Up(int value)
    {
        _value += Mathf.Max(0, value);
        ValueChanged?.Invoke(_value);
    }
}
