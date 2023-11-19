using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects;
using UnityEngine;


namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Concretes.OtherControllers
{
    public class FloorController : MonoBehaviour, IFloorController
    {
        [SerializeField] FloorSO _floorSO;

        public FloorSO FloorData => _floorSO;

        SpriteRenderer _spriteRenderer;
        public SpriteRenderer SpriteRenderer => _spriteRenderer;

        ISpriteRendererMover _spriteRendererMover;
        private void Awake()
        {
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            _spriteRendererMover = new FloorMover(this);
        }
        private void FixedUpdate()
        {
            _spriteRendererMover.SpriteRendererMove();
        }
    }

}