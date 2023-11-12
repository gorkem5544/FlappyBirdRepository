using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.EnemyCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.PlayerCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Concretes.PlayerCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.EnemyControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.PlayerControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Concretes.OtherControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Inputs.Abstracts;
using Assembly_CSharp.Assets.GameFolders.Scripts.Inputs.Concretes;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.OtherMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.PlayerMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.PlayerMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.PlayerScriptableObjects;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.PlayerScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Controllers
{
    public class PlayerController : MonoBehaviour, IPlayerController
    {

        IJumpWithPlayerController _jump;

        IPlayerDead _playerDead;
        public IPlayerDead PlayerDead => _playerDead;

        IPlayerMovement _rotate;

        IPlayerInput _playerInput;
        public IPlayerInput PlayerInput => _playerInput;

        [SerializeField] PlayerControllerSettings _playerSO;
        public IPlayerControllerSettings PlayerSO => _playerSO;

        Rigidbody2D _rigidbody2D;
        public Rigidbody2D Rigidbody2D => _rigidbody2D;


        private void Awake()
        {
            _rotate = new Rotate(this);
            _playerDead = new PlayerDead();
            _playerInput = new PlayerInput();
            _jump = new Jump(this);
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }


        private void Update()
        {
            if (_playerDead.IsDead) return;
            _jump.Update();
            _rotate.Update();
        }

        private void FixedUpdate()
        {
            _jump.FixedUpdate();
            _rotate.FixedUpdate();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            IWallAttacker wallAttacker = other.collider.GetComponentInChildren<IWallAttacker>();
            IFloorController floorController = other.collider.GetComponent<FloorController>();

            if (wallAttacker != null || floorController != null)
            {

                _playerDead.PlayerDeadAction();
            }


        }


    }

}