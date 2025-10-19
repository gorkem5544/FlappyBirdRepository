using System;
using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.PlayerCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using Concretes.Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.LeadBoardUis
{
    public class LeadBoardCurrentScore : MonoBehaviour
    {
        [SerializeField] Sprite[] _numbers;
        Dictionary<int, Sprite> _displayScoreDictionary = new Dictionary<int, Sprite>();
        [SerializeField] Image _leftScoreImg, _rightScoreImg;

        string _score;
        char[] _scoreChar;

        private void Awake()
        {
            for (int i = 0; i < 10; i++)
            {
                _displayScoreDictionary.Add(i, _numbers[i]);
            }
        }
        private void OnEnable()
        {

            _score = ScoreManager.Instance.Score.ToString();
            _scoreChar = _score.ToCharArray();
            if (_scoreChar.Length >= 2)
            {
                SetNumberImage(_leftScoreImg, _scoreChar[0]);
                SetNumberImage(_rightScoreImg, _scoreChar[1]);
            }
            else
            {
                SetNumberImage(_rightScoreImg, _scoreChar[0]);
            }
         
        }


        private void SetNumberImage(Image sprite, char index)
        {
            sprite.sprite = GetNumberImage(int.Parse(index.ToString()));
        }
        private Sprite GetNumberImage(int index)
        {
            return _displayScoreDictionary[index];
        }
    }

}