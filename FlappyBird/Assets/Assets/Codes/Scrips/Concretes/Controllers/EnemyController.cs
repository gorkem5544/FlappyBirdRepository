using Abstracts.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {

            _currentTime = 0;
            //WallPool.Instance.Set(this);

            SetEnemyPool();
        }

        public abstract void SetEnemyPool();

    }

}