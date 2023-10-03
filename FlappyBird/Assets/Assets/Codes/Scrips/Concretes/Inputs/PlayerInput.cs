using Abstracts.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Inputs
{
    public class PlayerInput : IPlayerInput
    {
        public bool JumpKeyDown => Input.GetKeyDown(KeyCode.Space);
    }
}
