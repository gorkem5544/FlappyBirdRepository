using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerController
{
    IJump _jump;
    IDead _dead;
    IRotate _rotate;

    IPlayerInput _playerInput;
    public IPlayerInput PlayerInput => _playerInput;

    [SerializeField] PlayerSO _playerSO;
    public IPlayerSO PlayerSO => _playerSO;

    private void Awake()
    {
        _rotate = new Rotate(this);
        _dead = GetComponent<Dead>();
        _playerInput = new PlayerInput();
        _jump = new Jump(this);
    }
    private void Update()
    {
        if (_dead.IsDead) return;
        _jump.UpdateJumpTick();
    }
    private void FixedUpdate()
    {
        _jump.FixedJumpTick();
        _rotate.RotateAction();
    }

}
