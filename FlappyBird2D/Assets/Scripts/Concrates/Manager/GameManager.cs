using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public event System.Action<int> OnScore;

    [SerializeField] int score;
    private void Awake()
    {
        SingeltonThisGameObjects();
    }


    public void IncreaseScore()
    {
        score += 10;
        OnScore?.Invoke(score);
    }

    private void SingeltonThisGameObjects()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
    }

    public void RestartGame()
    {
        score = 0;
        StartCoroutine(StartGame());
       
    }

    public IEnumerator StartGame()
    {
        yield return SceneManager.LoadSceneAsync("Game");
    }
}
