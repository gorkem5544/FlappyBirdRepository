using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Concretes.Uis
{
    public class DisplayScore : MonoBehaviour
    {

        [SerializeField] TextMeshProUGUI _textMeshProUGUI, _textHighScore;

        private void Awake()
        {
            _textHighScore.text = GameManager.Instance.HighScore.ToString();
        }
        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandeOnScoreChanged;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandeOnScoreChanged;

        }

        private void HandeOnScoreChanged(int obj)
        {
            _textMeshProUGUI.text = obj.ToString();
        }
    }

}