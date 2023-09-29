using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : IPlayerInput
{
    public bool JumpKeyDown => Input.GetKeyDown(KeyCode.Space);
}
