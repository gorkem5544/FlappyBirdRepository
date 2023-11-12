using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects
{

    [CreateAssetMenu(fileName = "SpriteRendererSO", menuName = "FlappyBird/SpriteRendererSO", order = 0)]
    public class SpriteRendererSO : ScriptableObject
    {
        [SerializeField] float _sizeSpeed;
        public float SizeSpeed { get => _sizeSpeed; set => _sizeSpeed = value; }
    }
}