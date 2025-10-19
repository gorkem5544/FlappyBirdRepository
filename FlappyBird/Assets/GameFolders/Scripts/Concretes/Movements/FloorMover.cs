using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.OtherMovements
{
    public class FloorMover : ISpriteRendererMover
    {
        IFloorController _floorController;
        public FloorMover(IFloorController floorController)
        {
            _floorController = floorController;
        }

        public void SpriteRendererMove()
        {
            _floorController.SpriteRenderer.size += Vector2.right * Time.deltaTime * _floorController.FloorData.SizeSpeed;
        }
    }

}