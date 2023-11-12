using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.EnemyCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Concretes.EnemyCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.EnemyControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.EnemyMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.EnemyMovements;
using Assembly_CSharp.Assets.GameFolders.Scripts.Pools.Concretes.EnemyPools;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.EnemyScriptableObjects;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.EnemyScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Concretes.EnemyControllers
{
    public class WallController : EnemyController, IWallController
    {
        IMoverWithWallController _moverWithWallController;
        [SerializeField] WallControllerSettings _wallControllerSetting;
        [SerializeField] NewBehaviourScript[] _wallAttackers;
        public IWallAttacker[] WallAttackers => _wallAttackers;

        public IWallControllerSettings WallControllerSettings => _wallControllerSetting;

        Rigidbody2D _wallControllerRigidBody2D;
        public Rigidbody2D WallControllerRigidBody2D => _wallControllerRigidBody2D;

        private void Awake()
        {
            _wallControllerRigidBody2D = GetComponent<Rigidbody2D>();
            _moverWithWallController = new MoverWithWallController(this);
        }
        private void OnEnable()
        {
            _moverWithWallController.OnEnable();
        }

        public override void SetPool()
        {
            WallPool.Instance.Set(this);
        }

        protected override float GetMaxLifeTime()
        {
            return _wallControllerSetting.MaxLifeTime;
        }
    }

}