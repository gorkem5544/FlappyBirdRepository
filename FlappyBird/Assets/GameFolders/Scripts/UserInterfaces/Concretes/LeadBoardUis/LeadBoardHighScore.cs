using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.LeadBoardUis
{
    public class LeadBoardHighScore : MonoBehaviour
    {
        [SerializeField] Sprite[] _numbers;
        Dictionary<int, Sprite> _displayHighScoreDictionary = new Dictionary<int, Sprite>();
        [SerializeField] Image _leftHighScoreImg, _rightHighScoreImg;

        string _highScore;
        char[] _highScoreChar;

        private void Awake()
        {
            for (int i = 0; i < 10; i++)
            {
                _displayHighScoreDictionary.Add(i, _numbers[i]);
            }
        }
        private void OnEnable()
        {

            _highScore = ScoreManager.Instance.HighScore.ToString();
            _highScoreChar = _highScore.ToCharArray();
            if (_highScoreChar.Length >= 2)
            {
                SetNumberImage(_leftHighScoreImg, _highScoreChar[0]);
                SetNumberImage(_rightHighScoreImg, _highScoreChar[1]);
            }
            else
            {
                SetNumberImage(_rightHighScoreImg, _highScoreChar[0]);
            }
        }


        private void SetNumberImage(Image sprite, char index)
        {
            sprite.sprite = GetNumberImage(int.Parse(index.ToString()));
        }
        private Sprite GetNumberImage(int index)
        {
            return _displayHighScoreDictionary[index];
        }
    }

}