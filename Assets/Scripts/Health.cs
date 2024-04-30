using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private Healthbar _healthbar;
    [SerializeField] private SmoothHealthbar _smoothHealthbar;
    [SerializeField] private HealthIndicator _healthIndicator;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        DisplayHealth();
    }


    private void DisplayHealth()
    {
        _healthbar.Display(_currentHealth, _maxHealth);
        _smoothHealthbar.Display(_currentHealth, _maxHealth);
        _healthIndicator.Display(_currentHealth, _maxHealth);
    }

    public void ChangeHealth(float healthChanger)
    {
        _currentHealth += healthChanger;

        if(_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
        else if(_currentHealth < 0f)
            _currentHealth = 0f;

        DisplayHealth();
    }
}
