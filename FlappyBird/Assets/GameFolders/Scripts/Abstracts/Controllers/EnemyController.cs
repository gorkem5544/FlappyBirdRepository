using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.EnemyControllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0;
            SetPool();
        }

        public abstract void SetPool();

    }

}