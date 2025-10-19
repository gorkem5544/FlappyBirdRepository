using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Abstracts.Buttons;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.Buttons.GameButtons
{
    public class OkButton : BaseButton
    {
        const string GameName = "Game";
        public System.Action ClickedEventHandler;
        protected override void HandleOnButtonClick()
        {
            ClickedEventHandler?.Invoke();
            LevelManager.Instance.LoadLevel(GameName);
        }
    }

}