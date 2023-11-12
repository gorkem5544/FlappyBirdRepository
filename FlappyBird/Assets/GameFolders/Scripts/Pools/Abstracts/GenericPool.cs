
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Pools.Abstracts
{
    public abstract class GenericPool<T> : SingletonDontDestroyMono<GenericPool<T>> where T : Component
    {
        [SerializeField] T[] _prefabs;
        [SerializeField] int _countLoop;

        Queue<T> _poolPrefabs = new Queue<T>();

        private void OnEnable()
        {
            LevelManager.Instance.OnSceneChanged += ResetAllObjects;
        }

        private void OnDisable()
        {
            LevelManager.Instance.OnSceneChanged -= ResetAllObjects;
        }


        public T Get()
        {
            if (_poolPrefabs.Count == 0)
            {
                GrowPoolPrefab();
            }
            return _poolPrefabs.Dequeue();
        }

        public abstract void ResetAllObjects();

        private void GrowPoolPrefab()
        {
            for (int i = 0; i < _countLoop; i++)
            {
                T newPrefab = Instantiate(_prefabs[Random.Range(0, _prefabs.Length)]);
                newPrefab.transform.parent = this.transform;
                newPrefab.gameObject.SetActive(false);
                _poolPrefabs.Enqueue(newPrefab);
            }

        }

        public void Set(T poolObject)
        {
            poolObject.gameObject.SetActive(false);
            _poolPrefabs.Enqueue(poolObject);
        }
    }

}