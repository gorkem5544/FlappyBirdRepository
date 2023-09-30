using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{

    TextMeshProUGUI _textMeshProUGUI;

    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        GameManager.Instance.OnScoreChanged += HandeOnScoreChanged;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnScoreChanged -= HandeOnScoreChanged;

    }

    private void HandeOnScoreChanged(int obj)
    {
        _textMeshProUGUI.text = obj.ToString();
    }
}
