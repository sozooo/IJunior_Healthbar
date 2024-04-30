using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealthCreaser : MonoBehaviour
{
    [SerializeField] private float _creaseAmount;

    private Button _button;
    private Health _health;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _health = FindObjectOfType<Health>();

        _button.onClick.AddListener(CreaseHealth);
    }

    private void CreaseHealth()
    {
        _health.ChangeHealth(_creaseAmount);
    }
}
