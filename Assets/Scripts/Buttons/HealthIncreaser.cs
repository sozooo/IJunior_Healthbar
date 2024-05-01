using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealthIncreaser : MonoBehaviour
{
    [SerializeField] private float _increaseAmount;
    [SerializeField] private Health _health;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(CreaseHealth);
    }

    private void CreaseHealth()
    {
        _health.Heal(_increaseAmount);
    }
}
