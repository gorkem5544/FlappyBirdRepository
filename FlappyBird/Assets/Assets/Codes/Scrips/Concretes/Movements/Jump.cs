using Abstracts.Controllers;
using Abstracts.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Movements
{
    public class Jump : IJump
    {
        Rigidbody2D _rigidbody2D;
        IPlayerController _playerController;

        private bool _isJumping;
        public Jump(IPlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody2D = playerController.transform.GetComponent<Rigidbody2D>();

        }

        public void UpdateJumpTick()
        {
            if (_playerController.PlayerInput.JumpKeyDown)
            {
                _isJumping = true;
            }

        }
        public void FixedJumpTick()
        {
            if (_isJumping)
            {
                _rigidbody2D.velocity = Vector2.zero;
                _rigidbody2D.AddForce(Vector2.up * _playerController.PlayerSO.JumpForce, ForceMode2D.Force);
                _isJumping = false;

            }
        }
    }

}