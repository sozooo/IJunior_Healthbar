using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class Healthbar : MonoBehaviour
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void Display(float currentHealth, float maxHealth)
    {
        _slider.value = currentHealth / maxHealth;
    }
}
