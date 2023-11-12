using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.OtherMovements
{
    public class SpriteRendererMover : ISpriteRendererMover
    {
        ISpriteRendererController _spriteRendererController;
        public SpriteRendererMover(ISpriteRendererController spriteRendererController)
        {
            _spriteRendererController = spriteRendererController;
        }
        public void SpriteRendererMove()
        {
            _spriteRendererController.SpriteRenderer.size += Vector2.right * Time.deltaTime * _spriteRendererController.SpriteRendererSO.SizeSpeed;
        }
    }

}