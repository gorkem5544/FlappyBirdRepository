using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Abstracts;
using Assembly_CSharp.Assets.GameFolders.Scripts.Spawners.Concretes.PlayerSpawners;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes
{
    public class SpawnerManager : SingletonDontDestroyMonoObject<SpawnerManager>
    {
        public System.Action OnSpawnPlayerEvent;
        public void SpawnPlayer()
        {
            OnSpawnPlayerEvent?.Invoke();
        }
    }

}