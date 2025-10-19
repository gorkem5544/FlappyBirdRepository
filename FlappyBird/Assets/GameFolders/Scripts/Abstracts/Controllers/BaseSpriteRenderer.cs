using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.OtherScriptableObjects;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers
{
    public abstract class BaseSpriteRendererController : MonoBehaviour, ISpriteRendererController
    {
        protected SpriteRenderer _spriteRenderer;
        public SpriteRenderer SpriteRenderer => _spriteRenderer;

        [SerializeField] protected SpriteRendererSO _spriteRendererSO;
        public SpriteRendererSO SpriteRendererData { get; set; }

        public float MoveSpeed { get; set; }

        protected ISpriteRendererMover _spriteRendererMover;
        protected virtual void Awake()
        {
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            _spriteRendererMover = new SpriteRendererMover(this);
        }
        private void FixedUpdate()
        {
            _spriteRendererMover.SpriteRendererMove();
        }

    }

}