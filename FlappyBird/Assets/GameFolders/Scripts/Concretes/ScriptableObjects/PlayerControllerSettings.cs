using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.PlayerScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.PlayerScriptableObjects
{
    [CreateAssetMenu(fileName = "Player Information", menuName = "Create New Player Information")]
    public class PlayerControllerSettings : ScriptableObject, IPlayerControllerSettings
    {
        [SerializeField] float _jumpForce;
        public float JumpForce => _jumpForce;
    }

}