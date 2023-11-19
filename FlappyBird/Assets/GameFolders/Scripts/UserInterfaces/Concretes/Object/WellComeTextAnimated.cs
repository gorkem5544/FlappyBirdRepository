using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.Object
{
    public class WellComeTextAnimated : MonoBehaviour
    {
        [SerializeField] Image _text1;
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1f;
        Vector3 _startPosition;
        float _factor;
        const float FULL_CIRCLE = Mathf.PI * 2f;

        private void Awake()
        {
            _startPosition = transform.localScale;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);

            // _factor = Mathf.Abs(sinWave);
            _factor = sinWave / 2f + 0.5f;

            Vector3 offset = _direction * _factor;
         
            _text1.transform.localScale = offset + _startPosition;
        }

    }

}