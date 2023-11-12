using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Concretes.PlayerCombats
{
    public class IncreaseScore : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            ScoreManager.Instance.IncreaseScore(1);
        }
    }

}