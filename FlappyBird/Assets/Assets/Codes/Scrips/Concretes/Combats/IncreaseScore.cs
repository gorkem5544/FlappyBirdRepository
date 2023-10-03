using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.Combats
{
    public class IncreaseScore : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            GameManager.Instance.IncreaseScore(1);
        }
    }

}