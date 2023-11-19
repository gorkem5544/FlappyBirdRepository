using System;
using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using Concretes.Controllers;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Spawners.Concretes.PlayerSpawners
{
    public class PlayerSpawner : MonoBehaviour
    {
        PlayerController _playerController;
        private void OnEnable()
        {
            SpawnerManager.Instance.OnSpawnPlayerEvent += HandleSpawnPlayer;
        }

        private void HandleSpawnPlayer()
        {

        }

        private void OnDisable()
        {

        }
    }

}