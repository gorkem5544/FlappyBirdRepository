using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonDontDestroyMono<GameManager>
{


    [SerializeField] int _score = 0;
    // public int Score => _score;

    int _highScore;
    // public int HighScore => _highScore;
    private const string PLAYER_SCORE = "Player_Score";

    //public event System.Action<int> OnScoreChanged;






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
