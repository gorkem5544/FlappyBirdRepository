using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.EnemyControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Pools.Concretes.EnemyPools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Spawners.Concretes.EnemySpawners
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] Transform[] _spawnerTransform;
        [SerializeField] float _maxRandomSpawnTime, _minRandomSpawnTime;
        float _timeBoundary, _currentTime;

        private void Start()
        {
            ResetTime();
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _timeBoundary)
            {
                SpawnAction();
                ResetTime();
            }
        }

        public void SpawnAction()
        {
            EnemyController newEnemyController = WallPool.Instance.Get();
            newEnemyController.transform.position = _spawnerTransform[Random.Range(0, _spawnerTransform.Length)].transform.position;
            newEnemyController.gameObject.SetActive(true);
        }
        public void ResetTime()
        {
            _timeBoundary = Random.Range(_minRandomSpawnTime, _maxRandomSpawnTime);
            _currentTime = 0;
        }

    }

}