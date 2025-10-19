using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.PlayerCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.Inputs.Abstracts;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.PlayerScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.PlayerControllers
{

    public interface IPlayerController : IEntityController
    {
        IPlayerInput PlayerInput { get; }
        IPlayerControllerSettings PlayerSO { get; }
        IPlayerDead PlayerDead { get; }
        Rigidbody2D Rigidbody2D { get; }

    }

}