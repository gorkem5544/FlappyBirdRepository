using System;
using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes
{
    public class DisplayScore : MonoBehaviour
    {
        [SerializeField] Sprite[] _numbers;
        Dictionary<int, Sprite> _displayScoreDictionary = new Dictionary<int, Sprite>();
        [SerializeField] Image _leftScoreImg, _rightScoreImg;
        int _rightIndex = 0;
        int _leftIndex = 0;

        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                _displayScoreDictionary.Add(i, _numbers[i]);
            }
            ScoreManager.Instance.OnScoreChanged += HandleOnScoreChanged;
        }
        private void OnDisable()
        {
            ScoreManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
        }

        private void HandleOnScoreChanged(int score)
        {
            _rightIndex++;
            if (score == 10)
            {
                _leftIndex++;
                _rightIndex = 0;
                SetScoreImage(_leftScoreImg, _leftIndex);
            }
            SetScoreImage(_rightScoreImg, _rightIndex);
        }
        private void SetScoreImage(Image image, int index)
        {
            image.sprite = GetNumberImage(index);

        }
        private Sprite GetNumberImage(int index)
        {
            return _displayScoreDictionary[index];
        }
    }

}