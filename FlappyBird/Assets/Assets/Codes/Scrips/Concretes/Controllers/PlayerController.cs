using Abstracts.Combats;
using Abstracts.Controllers;
using Abstracts.Inputs;
using Abstracts.Movements;
using Abstracts.SO;
using Concretes.Combats;
using Concretes.Inputs;
using Concretes.Movements;
using Concretes.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Controllers
{
    public class PlayerController : MonoBehaviour, IPlayerController
    {


        /// <summary>
        /// Player Control Class'�n tek bir g�revi vard�r Player Controlc�s� Jump,Dead,Input,SO,Rotate gibi i�lemleri Control etmesi gerekir Bu i�lemlerin kodlar�n� bilmesine gerek yok
        /// </summary>

        IJump _jump;

        IDead _dead;

        IRotate _rotate;

        IPlayerInput _playerInput;
        public IPlayerInput PlayerInput => _playerInput;

        [SerializeField] PlayerSO _playerSO;
        public IPlayerSO PlayerSO => _playerSO;



        private void Awake()
        {
            _rotate = new Rotate(this);
            _dead = GetComponent<Dead>();
            _playerInput = new PlayerInput();
            _jump = new Jump(this);
        }


        private void Update()
        {
            if (_dead.IsDead) return;
            _jump.UpdateJumpTick();
        }

        private void FixedUpdate()
        {
            _jump.FixedJumpTick();
            _rotate.RotateAction();
        }

    }

}