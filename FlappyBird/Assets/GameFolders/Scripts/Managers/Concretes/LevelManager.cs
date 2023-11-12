using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Abstracts;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes
{
    public class LevelManager : SingletonDontDestroyMonoObject<LevelManager>
    {
        public event System.Action OnSceneChanged;
        public void LoadLevel(string sceneName)
        {
            OnSceneChanged?.Invoke();
            StartCoroutine(LoadLevelAsync(sceneName));
            SetTimeScale(1);
            ScoreManager.Instance.ResetScore();

        }
        IEnumerator LoadLevelAsync(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void SetTimeScale(int value)
        {
            Time.timeScale = value;
        }
    }

}