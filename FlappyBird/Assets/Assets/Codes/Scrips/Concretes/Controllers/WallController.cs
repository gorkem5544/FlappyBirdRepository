using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : LifeCycleController, IWallController
{
    IMover _mover;
    [SerializeField] WallSO _wallSO;
    private void Awake()
    {
        _mover = new Mover(this);
    }
    private void Start()
    {
        _mover.MoveAction(_wallSO.MoveSpeed);
    }

}
