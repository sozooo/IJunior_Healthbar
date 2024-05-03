using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class HealthIndicator : Healthbar
{
    private TextMeshProUGUI textMeshPro;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    protected override void Display(float currentHealth)
    {
        textMeshPro.SetText(currentHealth.ToString());
    }
}
