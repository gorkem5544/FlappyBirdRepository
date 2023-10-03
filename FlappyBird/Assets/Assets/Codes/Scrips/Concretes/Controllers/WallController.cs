using Abstracts.Controllers;
using Abstracts.Movements;
using Concretes.Movements;
using Concretes.Pools;
using Concretes.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Controllers
{
    public class WallController : EnemyController, IWallController
    {
        IMover _mover;
        [SerializeField] WallSO _wallSO;

        private void Awake()
        {
            _mover = new Mover(this);
        }

        public override void SetEnemyPool()
        {
            WallPool.Instance.Set(this);
        }
        private void OnEnable()
        {
            _mover.MoveAction(_wallSO.MoveSpeed);
        }

    }

}