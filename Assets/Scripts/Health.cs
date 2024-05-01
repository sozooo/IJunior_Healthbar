using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private Healthbar _healthbar;
    [SerializeField] private SmoothHealthbar _smoothHealthbar;
    [SerializeField] private HealthIndicator _healthIndicator;

    private float _currentHealth;

    public float CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
        private set
        {
            _currentHealth = value;

            OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
        }
    }

    public delegate void HealthChanged (float health, float maxHeatlh);
    public event HealthChanged OnHealthChanged;

    private void Start()
    {
        CurrentHealth = _maxHealth;

        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
    }

    public void Heal(float healAmount)
    {
        CurrentHealth = Mathf.Clamp(_currentHealth + healAmount, 0f, _maxHealth);
    }

    public void TakeDamage(float damage)
    {
        CurrentHealth = Mathf.Clamp(_currentHealth - damage, 0f, _maxHealth);
    }
}
