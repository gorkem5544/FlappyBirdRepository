using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        protected float _currentTime;
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > GetMaxLifeTime())
            {
                KillGameObject();
            }
        }
        protected abstract float GetMaxLifeTime();

        public abstract void KillGameObject();
    }

}