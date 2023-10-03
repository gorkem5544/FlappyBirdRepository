using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonDontDestroyMono<GameManager>
{


    [SerializeField] int _score = 0;
    public int Score => _score;

    int _highScore;
    public int HighScore => _highScore;
    private const string PLAYER_SCORE = "Player_Score";

    public event System.Action<int> OnScoreChanged;
    public event System.Action OnSceneChanged;





    public void IncreaseScore(int scoreAmount)
    {
        _score += scoreAmount;
        if (_score > _highScore)
        {
            PlayerPrefs.SetInt(PLAYER_SCORE, _score);

        }

        OnScoreChanged?.Invoke(_score);
    }



    public void LoadGame(string sceneName)
    {
        GetSaveScore();
        StartCoroutine(LoadSceneAsync(sceneName));
        Time.timeScale = 1;
        _score = 0;
    }
    IEnumerator LoadSceneAsync(string sceneName)
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
    private void GetSaveScore()
    {
        if (PlayerPrefs.HasKey(PLAYER_SCORE))
        {
            _highScore = PlayerPrefs.GetInt(PLAYER_SCORE);

        }
    }
}

public abstract class SingletonDontDestroyMono<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
