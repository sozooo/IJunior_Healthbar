using UnityEngine;

public abstract class Healthbar : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected float _maxHealth;

    private void OnEnable()
    {
        _maxHealth = _health.MaxHealth;

        _health.OnHealthChanged += Display;
    }

    private void OnDisable()
    {
        _health.OnHealthChanged -= Display;
    }

    protected abstract void Display(float _currentHealth);
}
