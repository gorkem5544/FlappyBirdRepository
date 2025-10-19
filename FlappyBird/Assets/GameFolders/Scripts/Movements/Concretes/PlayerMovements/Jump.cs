using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.PlayerControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.PlayerMovements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.PlayerMovements
{
    public class Jump : IJumpWithPlayerController
    {
        IPlayerController _playerController;
        private bool _isJumping;
        public Jump(IPlayerController playerController)
        {
            _playerController = playerController;
        }

        public void Update()
        {
            if (_playerController.PlayerInput.JumpKeyDown)
            {
                _isJumping = true;
            }
        }
        public void FixedUpdate()
        {
            if (_isJumping)
            {
                _playerController.Rigidbody2D.linearVelocity = Vector2.zero;
                _playerController.Rigidbody2D.AddForce(Vector2.up * _playerController.PlayerSO.JumpForce, ForceMode2D.Force);
                _isJumping = false;
            }
        }
    }

}