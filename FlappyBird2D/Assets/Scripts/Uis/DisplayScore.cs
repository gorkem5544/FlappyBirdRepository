using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        GameManager.instance.OnScore += HandleOnScoreChanged;
        HandleOnScoreChanged();
    }

    private void OnDisable()
    {
        GameManager.instance.OnScore -= HandleOnScoreChanged;
    }

    private void HandleOnScoreChanged(int score = 0)
    {
        textMesh.text = $"Score:{score}";
    }
}
