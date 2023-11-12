using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers
{
    public abstract class BaseSpriteRendererController : MonoBehaviour, ISpriteRendererController
    {
        private SpriteRenderer _spriteRenderer;
        public SpriteRenderer SpriteRenderer => _spriteRenderer;

        [SerializeField] SpriteRendererSO _spriteRendererSO;
        public SpriteRendererSO SpriteRendererSO => _spriteRendererSO;

        protected ISpriteRendererMover _spriteRendererMover;
        protected virtual void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _spriteRendererMover = new SpriteRendererMover(this);
        }
        private void FixedUpdate()
        {
            _spriteRendererMover.SpriteRendererMove();
        }

    }

}