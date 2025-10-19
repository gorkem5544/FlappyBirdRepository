using System.Collections;
using System.Collections.Generic;
using Assembly_CSharp.Assets.GameFolders.Scripts.Managers.Concretes;
using UnityEngine;
using UnityEngine.UI;

namespace Assembly_CSharp.Assets.GameFolders.Scripts.UserInterfaces.Concretes.LeadBoardUis
{
    public class MedallionImage : MonoBehaviour
    {
        [SerializeField] Sprite[] _medallions;
        Dictionary<int, Sprite> keyValuePairs = new Dictionary<int, Sprite>();
        Image _medallionsImage;

        private void Awake()
        {



        }

        private void Start()
        {
            if (ScoreManager.Instance.Score >= 20)
            {
                SetMedallionImage(3);
            }
            else if (ScoreManager.Instance.Score >= 15)
            {
                SetMedallionImage(2);
            }
            else if (ScoreManager.Instance.Score >= 10)
            {
                SetMedallionImage(1);
            }
            else if (ScoreManager.Instance.Score >= 5)
            {
                SetMedallionImage(0);
            }
            else
            {
                _medallionsImage.color = new Color(0, 0, 0, 0);
            }
        }
        private void OnEnable()
        {

            for (int i = 0; i < _medallions.Length; i++)
            {
                keyValuePairs.Add(i, _medallions[i]);
               
            }
            _medallionsImage = GetComponent<Image>();

        }
        private void SetMedallionImage(int index)
        {
            _medallionsImage.sprite = GetNumberImage(index);
        }
        private Sprite GetNumberImage(int index)
        {
            return keyValuePairs[index];
        }

    }

}