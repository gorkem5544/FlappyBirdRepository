using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.PlayerMovements
{
    public interface IPlayerMovement
    {
        void Update();
        void FixedUpdate();
    }
    public interface IUpdateService
    {
        void Update();
    }
    public interface IFixedUpdateService
    {
        void FixedUpdate();
    }
    public interface IOnEnableService
    {
        void OnEnable();
    }

}