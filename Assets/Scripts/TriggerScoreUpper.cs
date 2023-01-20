using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TriggerScoreUpper : MonoBehaviour
{
    [SerializeField] private int _scoreUpValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Score>(out Score score))
        {
            score.Up(_scoreUpValue);
        }
    }
}
