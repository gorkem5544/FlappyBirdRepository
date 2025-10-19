using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Abstracts;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes
{
    public class ScoreManager : SingletonDontDestroyMonoObject<ScoreManager>
    {
        [SerializeField] int _score = 0;
        public int Score => _score;

        int _highScore;
        public int HighScore => _highScore;
        private const string PLAYER_SCORE = "Player_Score";

        public event System.Action<int> OnScoreChanged;

        public void IncreaseScore(int scoreAmount)
        {
            _score += scoreAmount;
            if (_score > _highScore)
            {
                PlayerPrefs.SetInt(PLAYER_SCORE, _score);
                GetSaveScore();
            }
            OnScoreChanged?.Invoke(_score);
        }
        public void ResetScore()
        {
            _score = 0;
        }
        private void GetSaveScore()
        {
            if (PlayerPrefs.HasKey(PLAYER_SCORE))
            {
                _highScore = PlayerPrefs.GetInt(PLAYER_SCORE);
            }
        }
    }

}