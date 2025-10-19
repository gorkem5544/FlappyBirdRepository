using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Abstracts.Buttons
{
    public abstract class BaseButton : MonoBehaviour
    {
        [SerializeField] Button _button;
        private void OnEnable()
        {
            _button.onClick.AddListener(HandleOnButtonClick);
        }
        private void OnDisable()
        {
            _button.onClick.RemoveListener(HandleOnButtonClick);
        }

        protected abstract void HandleOnButtonClick();

    }

}