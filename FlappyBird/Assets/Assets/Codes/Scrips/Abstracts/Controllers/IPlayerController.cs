using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerController : IEntityController
{
    IPlayerInput PlayerInput { get; }
    IPlayerSO PlayerSO { get; }

}
