using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : IMover
{
    Rigidbody2D _rigidbody2D;
    public Mover(IWallController wallController)
    {
        _rigidbody2D = wallController.transform.GetComponent<Rigidbody2D>();
    }
    public void MoveAction(float moveSpeed)
    {
        _rigidbody2D.velocity = Vector2.left * Time.deltaTime * moveSpeed;
    }
}
