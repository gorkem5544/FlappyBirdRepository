using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Uis
{
    public class GameOverPanel : MonoBehaviour
    {

        public void YesButton()
        {
            GameManager.Instance.LoadGame("Game");
        }
        public void NoButton()
        {
            Application.Quit();
        }
    }

}