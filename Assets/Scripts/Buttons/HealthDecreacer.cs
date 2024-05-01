using UnityEngine;
using UnityEngine.UI;

public class HealthDecreacer : MonoBehaviour
{
    [SerializeField] private float _decreaseAmount;
    [SerializeField] private Health _health;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(CreaseHealth);
    }

    private void CreaseHealth()
    {
        _health.TakeDamage(_decreaseAmount);
    }
}
