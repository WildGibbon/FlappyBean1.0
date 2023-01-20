using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean : MonoBehaviour
{
    [SerializeField] private bool _isDying;
    [SerializeField] private GameObject _gameOverMenu;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }

    private void Die()
    {
        Time.timeScale = 0;
        _gameOverMenu.SetActive(true);
    }
}
