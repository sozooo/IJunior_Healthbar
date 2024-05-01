using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private Healthbar _healthbar;
    [SerializeField] private SmoothHealthbar _smoothHealthbar;
    [SerializeField] private HealthIndicator _healthIndicator;

    private float _currentHealth;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void Heal(float healAmount)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + healAmount, 0f, _maxHealth);
    }

    public void TakeDamage(float damage)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - damage, 0f, _maxHealth);
    }
}
