using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeCycleController : MonoBehaviour
{
    [SerializeField] protected float _maxLifeTime;
    protected float _currentTime;
    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _maxLifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}
