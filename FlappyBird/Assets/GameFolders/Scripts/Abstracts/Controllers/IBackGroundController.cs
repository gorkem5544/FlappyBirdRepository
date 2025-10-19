using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.ScriptableObjects.Concretes.OtherScriptableObjects;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.OtherControllers
{
    public interface IBackGroundController
    {
        BackGroundSO BackGroundData { get; }
        SpriteRenderer SpriteRenderer { get; }
    }

}