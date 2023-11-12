using Assembly_CSharp.Assets.GameFolders.Scripts.Controllers.Abstracts.PlayerControllers;
using Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Abstracts.PlayerMovements;
using UnityEngine;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.Movements.Concretes.PlayerMovements
{
    public class Rotate : IPlayerMovement
    {
        IPlayerController _playerController;
        float angle;
        public Rotate(IPlayerController playerController)
        {
            _playerController = playerController;
        }


        public void Update()
        {
            angle = Vector3.Angle(Vector3.right, _playerController.Rigidbody2D.velocity);
            if (_playerController.Rigidbody2D.velocity.y < 0)
            {
                angle = -angle;
            }
        }
        public void FixedUpdate()
        {
            _playerController.transform.eulerAngles = new Vector3(0, 0, Unity.Mathematics.math.clamp(angle, -15f, 15f));
        }
    }

}