using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.OtherMovements
{
    public class BackGroundMover : ISpriteRendererMover
    {
        IBackGroundController _backGroundController;
        public BackGroundMover(IBackGroundController backGroundController)
        {

            _backGroundController = backGroundController;
        }
        public void SpriteRendererMove()
        {
            _backGroundController.SpriteRenderer.size += Vector2.right * Time.deltaTime * _backGroundController.BackGroundData.SizeSpeed;
        }
    }

}