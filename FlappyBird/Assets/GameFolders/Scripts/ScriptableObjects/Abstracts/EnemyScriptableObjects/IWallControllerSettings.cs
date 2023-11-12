using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.EnemyScriptableObjects
{
    public interface IWallControllerSettings
    {
        float MoveSpeed { get; }
        public float MaxLifeTime { get; }
    }

}