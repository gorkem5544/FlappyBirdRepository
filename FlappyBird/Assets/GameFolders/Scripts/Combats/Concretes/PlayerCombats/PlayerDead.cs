
using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.PlayerCombats;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Concretes.PlayerCombats
{
    public class PlayerDead : IPlayerDead
    {
        private bool _isDead;
        public bool IsDead => _isDead;
        public event System.Action OnDead;
        public void PlayerDeadAction()
        {
            _isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0;
        }

    }

}