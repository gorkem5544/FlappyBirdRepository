using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Abstracts.Buttons;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.Buttons.MenuButtons
{
    public class GameStartButton : BaseButton
    {
        const string GameName = "Game";
        protected override void HandleOnButtonClick()
        {
            LevelManager.Instance.LoadLevel(GameName);
        }
    }

}