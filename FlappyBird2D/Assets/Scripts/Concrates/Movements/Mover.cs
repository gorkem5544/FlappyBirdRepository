using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField] float moveSpeed;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        rigidbody2D.velocity = new Vector2(-moveSpeed, rigidbody2D.velocity.y);
    }
}
