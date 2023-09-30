using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] WallController _wallController;
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
        WallController newWallController = Instantiate(_wallController, _spawnerTransform[Random.Range(0, _spawnerTransform.Length)].position, Quaternion.identity);
        


    }
    public void ResetTime()
    {
        _timeBoundary = Random.Range(_minRandomSpawnTime, _maxRandomSpawnTime);
        _currentTime = 0;
    }

}
