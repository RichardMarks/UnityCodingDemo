using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    private TextMeshProUGUI text;
    public int score = 0;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateText();
    }

    private void UpdateText()
    {
        text.text = string.Format("score: {0}", score);
    }
}
