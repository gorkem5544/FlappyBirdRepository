using Concretes.Combats;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Uis
{
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
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
        }


        private void HandleOnDead()
        {
            _gameOverPanel.SetActive(true);
        }
    }

}