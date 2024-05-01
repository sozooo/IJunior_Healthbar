using UnityEngine;

public class HealthbarDisplay : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Healthbar _healthbar;
    [SerializeField] private SmoothHealthbar _smoothHealthbar;
    [SerializeField] private HealthIndicator _healthIndicator;

    private float _healthBeforeChange;

    private void Start()
    {
        _healthBeforeChange = _health.CurrentHealth;
    }

    private void Update()
    {
        if(_healthBeforeChange != _health.CurrentHealth)
        {
            _healthBeforeChange = _health.CurrentHealth;

            DisplayHealth(_health.CurrentHealth, _health.MaxHealth);
        }
    }

    private void DisplayHealth(float currentHealth, float maxHealth)
    {
        _healthbar.Display(currentHealth, maxHealth);
        _smoothHealthbar.Display(currentHealth, maxHealth);
        _healthIndicator.Display(currentHealth, maxHealth);
    }
}
