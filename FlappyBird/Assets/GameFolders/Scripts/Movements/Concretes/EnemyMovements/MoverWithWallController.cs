using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.EnemyControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.EnemyMovements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.EnemyMovements
{
    public class MoverWithWallController : IMoverWithWallController
    {
        IWallController _wallController;
        public MoverWithWallController(IWallController wallController)
        {
            _wallController = wallController;
        }
        public void OnEnable()
        {
            _wallController.WallControllerRigidBody2D.linearVelocity = Vector2.left * Time.fixedDeltaTime * _wallController.WallControllerSettings.MoveSpeed;
        }
    }

}