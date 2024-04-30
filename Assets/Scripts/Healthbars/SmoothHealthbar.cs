using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothHealthbar : MonoBehaviour
{
    [SerializeField] private float _step;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void Display(float currentHealth, float maxHealth)
    {
        StopAllCoroutines();
        StartCoroutine(SmoothDisplaing(currentHealth, maxHealth));
    }

    private IEnumerator SmoothDisplaing(float currentHealth, float maxHealth)
    {
        while (_slider.value != currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth / maxHealth, _step * Time.deltaTime);
            yield return null;

        }
    }
}
