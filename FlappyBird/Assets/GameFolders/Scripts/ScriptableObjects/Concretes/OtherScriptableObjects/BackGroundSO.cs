using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects
{
    using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.OtherScriptableObjects;
    using UnityEngine;

    [CreateAssetMenu(fileName = "BackGroundSO", menuName = "FlappyBird/BackGroundSO", order = 0)]
    public class BackGroundSO : SpriteRendererSO
    {
        [SerializeField] Sprite _daySprite, _nightSprite;
        public Sprite DaySprite { get => _daySprite; set => _daySprite = value; }
        public Sprite NightSprite { get => _nightSprite; set => _nightSprite = value; }

    }
}