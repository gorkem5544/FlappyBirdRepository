using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : IJump
{
    Rigidbody2D _rigidbody2D;

    public Jump(IPlayerController playerController)
    {
        _rigidbody2D = playerController.transform.GetComponent<Rigidbody2D>();

    }
    public void JumpAction(float jumpForce, bool JumpKeyDown)
    {
        if (JumpKeyDown)
        {
            _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.AddForce(Vector2.up * Time.deltaTime * jumpForce, ForceMode2D.Force);
        }

    }
}
