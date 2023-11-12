using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Abstracts
{
    public abstract class SingletonMonoObject<S> : MonoBehaviour where S : MonoBehaviour
    {
        public static S Instance { get; set; }

        protected virtual void Awake()
        {
            SetSingletonMono();
        }
        protected abstract void SetSingletonMono();

    }

}