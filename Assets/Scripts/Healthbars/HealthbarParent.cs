using UnityEngine;

public class HealthbarDisplay : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Healthbar _healthbar;
    [SerializeField] private SmoothHealthbar _smoothHealthbar;
    [SerializeField] private HealthIndicator _healthIndicator;

    private void Start()
    {
        _health.OnHealthChanged += DisplayHealth;
    }

    private void DisplayHealth(float currentHealth, float maxHealth)
    {
        _healthbar.Display(currentHealth, maxHealth);
        _smoothHealthbar.Display(currentHealth, maxHealth);
        _healthIndicator.Display(currentHealth, maxHealth);
    }
}
