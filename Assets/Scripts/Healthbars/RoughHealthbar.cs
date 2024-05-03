using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class RoughHealthbar : Healthbar
{
    protected Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    protected override void Display(float currentHealth)
    {
        _slider.value = currentHealth / _maxHealth;
    }
}
