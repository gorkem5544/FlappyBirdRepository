using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayerController
{
    IJump _jump;
    IPlayerInput _playerInput;
    [SerializeField] float _jumpForce;
    private void Awake()
    {
        _playerInput = new PlayerInput();
        _jump = new Jump(this);
    }
    private void Update()
    {
        _jump.JumpAction(_jumpForce, _playerInput.JumpKeyDown);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.Instance.Dead();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.Instance.IncreaseScore(1);
    }
}
