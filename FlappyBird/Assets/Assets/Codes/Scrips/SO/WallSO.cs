using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Wall Information", menuName = "New Wall Information/Create New")]
public class WallSO : ScriptableObject, IWallSO
{
    [SerializeField] float _moveSpeed;
    public float MoveSpeed => _moveSpeed;
}
