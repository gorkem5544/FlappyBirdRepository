using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverObj : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;


    private void Awake()
    {
        if (_gameOverPanel.activeSelf == true)
        {
            _gameOverPanel.SetActive(false);
        }

    }
    private void Start()
    {
        GameManager.Instance.OnDead += HandleOnDead;
    }



    private void OnDisable()
    {
        GameManager.Instance.OnDead -= HandleOnDead;
    }

    private void HandleOnDead()
    {
        _gameOverPanel.SetActive(true);
    }
}