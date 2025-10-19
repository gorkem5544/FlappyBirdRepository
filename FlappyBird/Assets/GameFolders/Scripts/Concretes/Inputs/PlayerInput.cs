using Assembly_CSharp.Assets.GameFolders.Scripts.Inputs.Abstracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Inputs.Concretes
{
    public class PlayerInput : IPlayerInput
    {
        DefaultInput _inputActions;
        public bool JumpKeyDown { get; set; }
        public PlayerInput()
        {
            _inputActions = new DefaultInput();
            _inputActions.Player.Jump.performed += context => JumpKeyDown = context.ReadValueAsButton();
            _inputActions.Enable();
        }
    }
}
