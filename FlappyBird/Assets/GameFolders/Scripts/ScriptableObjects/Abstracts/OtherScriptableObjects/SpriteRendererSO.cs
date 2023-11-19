using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.OtherScriptableObjects
{

    [CreateAssetMenu(fileName = "SpriteRendererSO", menuName = "FlappyBird/SpriteRendererSO", order = 0)]
    public abstract class SpriteRendererSO : ScriptableObject
    {
        [SerializeField] protected float _sizeSpeed;
        public float SizeSpeed { get => _sizeSpeed; set => _sizeSpeed = value; }

    }
}