using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using UnityEngine;
using UnityEngine.UI;

public class LeadBoardController : MonoBehaviour
{
    [SerializeField] Sprite[] _medallion;
    Dictionary<int, Sprite> _leadBoardDisplayController = new Dictionary<int, Sprite>();

    [SerializeField] Image _image;
    int _index = 0;
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            _leadBoardDisplayController.Add(i, _medallion[i]);
        }
        ScoreManager.Instance.OnScoreChanged += HandleOnScoreChanged;
    }
    private void OnDisable()
    {
        ScoreManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
    }

    private void HandleOnScoreChanged(int score)
    {
        if (score > ScoreManager.Instance.HighScore)
        {
            if (score >= 10 && score == 0)
            {
                _index++;
                if (score >= 15)
                {
                    _index++;
                }
            }
            _image.sprite = GetNumberImage(_index);
        }
    }
    private Sprite GetNumberImage(int index)
    {
        return _leadBoardDisplayController[index];
    }
}
