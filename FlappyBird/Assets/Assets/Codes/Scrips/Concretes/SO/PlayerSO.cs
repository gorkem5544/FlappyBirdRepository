using Abstracts.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Concretes.SO
{
    [CreateAssetMenu(fileName = "Player Information", menuName = "Create New Player Information")]
    public class PlayerSO : ScriptableObject, IPlayerSO
    {
        [SerializeField] float _jumpForce;
        public float JumpForce => _jumpForce;
    }

}