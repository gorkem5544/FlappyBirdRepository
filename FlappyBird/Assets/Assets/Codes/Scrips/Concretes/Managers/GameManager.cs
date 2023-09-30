using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonDontDestroyMono<GameManager>
{


    [SerializeField] int _score;
    public event System.Action<int> OnScoreChanged;
    public event System.Action OnDead;

  
    public void IncreaseScore(int scoreAmount)
    {
        _score += scoreAmount;
        OnScoreChanged?.Invoke(_score);
    }

   
    public void Dead()
    {
        Time.timeScale = 0;
        OnDead?.Invoke();
    }
    public void LoadGame(string sceneName)
    {
        StartCoroutine(LoadSceneAsync(sceneName));
        Time.timeScale = 1;
        _score = 0;
    }
    IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
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
