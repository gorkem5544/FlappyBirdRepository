using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.EnemyCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.EnemyControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.EnemyScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.EnemyControllers
{
    public interface IWallController : IEnemyController
    {
        IWallControllerSettings WallControllerSettings { get; }
        IWallAttacker[] WallAttackers { get; }
        Rigidbody2D WallControllerRigidBody2D { get; }
    }

}