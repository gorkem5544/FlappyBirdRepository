using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Abstracts.OtherScriptableObjects;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers
{
    public interface ISpriteRendererController : IEntityController
    {
        SpriteRenderer SpriteRenderer { get; }
        SpriteRendererSO SpriteRendererData { get; }
        float MoveSpeed { get; }

    }

}