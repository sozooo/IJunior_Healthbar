using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxHealth;

    private float _currentHealth;

    public float MaxHealth => _maxHealth;
    private float CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;

            OnHealthChanged?.Invoke(_currentHealth);
        }
    }

    public event Action<float> OnHealthChanged;

    private void Start()
    {
        CurrentHealth = _maxHealth;

        OnHealthChanged?.Invoke(_currentHealth);
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
