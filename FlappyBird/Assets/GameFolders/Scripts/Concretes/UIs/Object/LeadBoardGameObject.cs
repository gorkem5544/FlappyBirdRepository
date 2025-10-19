using System;
using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Combats.Abstracts.PlayerCombats;
using Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.Buttons.GameButtons;
using Concretes.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.Object
{
    public class LeadBoardGameObject : MonoBehaviour
    {
        [SerializeField] GameObject _leadBoardPanel;

        [SerializeField] OkButton _LeadBoardOkButton;

        private void Start()
        {
            LeadBoardPanelActiveController(false);

            IPlayerDead dead = FindObjectOfType<PlayerController>().PlayerDead;
            dead.OnDead += HandleOpenLeadBoardPanel;
        }


        private void HandleOpenLeadBoardPanel()
        {
            LeadBoardPanelActiveController(true);
        }
        private void HandleClosedLeadBoardPanel()
        {
            LeadBoardPanelActiveController(false);
        }
        private void LeadBoardPanelActiveController(bool isActive)
        {
            _leadBoardPanel.gameObject.SetActive(isActive);
        }

    }

}