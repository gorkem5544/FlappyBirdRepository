using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Concretes.OtherControllers
{
    public class BackGroundController : MonoBehaviour, IBackGroundController
    {
        float _currentTime = 0;
        float _timeBoundary;
        [SerializeField] BackGroundSO _backGroundSO;
        public BackGroundSO BackGroundData => _backGroundSO;

        SpriteRenderer _spriteRenderer;
        public SpriteRenderer SpriteRenderer => _spriteRenderer;
        ISpriteRendererMover _spriteRendererMover;

        private void Awake()
        {
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            _spriteRendererMover = new BackGroundMover(this);

        }
        private void Start()
        {
            ResetTime();
            SetBoundary();
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _timeBoundary)
            {
                _spriteRenderer.sprite = GetSprite();
                ResetTime();
                SetBoundary();
            }

        }
        private void FixedUpdate()
        {
            _spriteRendererMover.SpriteRendererMove();
        }
        private void ResetTime()
        {
            _currentTime = 0;
        }
        private void SetBoundary()
        {
            _timeBoundary = Random.Range(0, 5);
        }
        private Sprite GetSprite()
        {
            int _randomIndex = Random.Range(0, 2);
            if (_randomIndex == 0)
            {
                return _backGroundSO.NightSprite;
            }
            return _backGroundSO.DaySprite;
        }
    }
}

