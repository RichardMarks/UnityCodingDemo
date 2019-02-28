using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthKeeper : MonoBehaviour
{
    private TextMeshProUGUI text;
    public Health health;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

    public void UpdateText()
    {
        text.text = string.Format("health: {0,4} / {1,4}", health.currentHealth.ToString(), health.maximumHealth.ToString());
    }
}
