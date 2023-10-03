using Abstracts.Controllers;
using Abstracts.Movements;
using UnityEngine;

namespace Concretes.Movements
{
    public class Rotate : IRotate
    {
        IPlayerController _playerController;
        Rigidbody2D _rigidbody2D;

        public Rotate(IPlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody2D = playerController.transform.GetComponent<Rigidbody2D>();
        }

        public void RotateAction()
        {

            float angle = Vector3.Angle(Vector3.right, _rigidbody2D.velocity);
            if (_rigidbody2D.velocity.y < 0)
                angle = -angle;

            _playerController.transform.eulerAngles = new Vector3(0, 0, Unity.Mathematics.math.clamp(angle, -15f, 15f));
        }
    }

}