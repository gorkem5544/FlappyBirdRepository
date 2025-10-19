using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.EnemyScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.EnemyScriptableObjects
{
    [CreateAssetMenu(fileName = "Wall Information", menuName = "New Wall Information/Create New")]
    public class WallControllerSettings : ScriptableObject, IWallControllerSettings
    {
        [Header("Move Infos")]
        [SerializeField] float _moveSpeed;
        public float MoveSpeed => _moveSpeed;

        [Header("Life Cycle Infos")]
        [SerializeField] float _maxLifeTime;
        public float MaxLifeTime => _maxLifeTime;
    }


}