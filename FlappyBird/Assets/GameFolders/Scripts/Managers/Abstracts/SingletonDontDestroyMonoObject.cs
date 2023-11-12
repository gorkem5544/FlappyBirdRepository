using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Abstracts
{
    public abstract class SingletonDontDestroyMonoObject<S> : SingletonMonoObject<S> where S : MonoBehaviour
    {
        protected override void SetSingletonMono()
        {
            if (Instance == null)
            {
                Instance = this as S;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

}