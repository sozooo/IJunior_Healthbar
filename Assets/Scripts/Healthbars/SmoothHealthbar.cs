using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothHealthbar : MonoBehaviour
{
    [SerializeField] private float _changeTime;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void Display(float currentHealth, float maxHealth)
    {
        StopCoroutine(nameof(SmoothDisplaing));
        StartCoroutine(SmoothDisplaing(currentHealth, maxHealth));
    }

    private IEnumerator SmoothDisplaing(float currentHealth, float maxHealth)
    {
        float startValue = _slider.value;
        float timeGone = 0f;

        while (timeGone <= _changeTime)
        {
            timeGone += Time.deltaTime;

            _slider.value = Mathf.Lerp(startValue, currentHealth / maxHealth, timeGone / _changeTime);
            yield return null;
        }
    }
}
