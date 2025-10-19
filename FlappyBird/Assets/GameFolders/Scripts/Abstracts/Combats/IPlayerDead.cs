using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.PlayerCombats
{
    public interface IPlayerDead
    {
        bool IsDead { get; }
        event System.Action OnDead;
        void PlayerDeadAction();
    }

}