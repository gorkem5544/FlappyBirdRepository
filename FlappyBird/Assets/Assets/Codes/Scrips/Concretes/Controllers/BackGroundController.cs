using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{

    [SerializeField] SpriteRenderer _backGroundRenderer, _groundRenderer;

    private void Update()
    {
        MoveSpriteRenderer(_backGroundRenderer, _groundRenderer);
    }

    public void MoveSpriteRenderer(params SpriteRenderer[] sprites)
    {
        foreach (SpriteRenderer spriteRenderer in sprites)
        {
            spriteRenderer.size += Vector2.right * Time.deltaTime * 10f;
        }
    }
}
