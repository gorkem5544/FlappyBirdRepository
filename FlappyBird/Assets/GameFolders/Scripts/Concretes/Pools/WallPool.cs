using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Concretes.EnemyControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Pools.Abstracts;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Pools.Concretes.EnemyPools
{
    public class WallPool : GenericPool<WallController>
    {
        public override void ResetAllObjects()
        {
            foreach (WallController child in GetComponentsInChildren<WallController>())
            {
                if (!child.gameObject.activeSelf)
                {
                    return;
                }
                child.KillGameObject();
            }

        }
    }

}