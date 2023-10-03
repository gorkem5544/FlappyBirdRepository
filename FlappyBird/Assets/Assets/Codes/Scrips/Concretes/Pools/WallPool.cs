using Abstracts.Pools;
using Concretes.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Pools
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