using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Abstracts.Buttons;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.Buttons.GameButtons
{
    public class ReturnMenuButton : BaseButton
    {
        const string MenuName = "Menu";
        protected override void HandleOnButtonClick()
        {
            LevelManager.Instance.LoadLevel(MenuName);
        }
    }

}