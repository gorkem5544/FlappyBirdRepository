using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour, IDead
{
    [SerializeField] bool _isDead;
    public bool IsDead => _isDead;

    public event System.Action OnDead;
    private void OnCollisionEnter2D(Collision2D other)
    {

        _isDead = true;
        Time.timeScale = 0;
        OnDead?.Invoke();
    }
}
