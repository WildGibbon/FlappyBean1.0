using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class ScoreView : MonoBehaviour
{
    [SerializeField] private Score _score;

    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        _score.ValueChanged += OnScoreValueChanged;
    }

    private void OnDisable()
    {
        _score.ValueChanged -= OnScoreValueChanged;
    }

    private void OnScoreValueChanged(int value)
    {
        _text.text = value.ToString();
    }
}
