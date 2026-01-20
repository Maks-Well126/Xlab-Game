using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Image m_bar;
    [SerializeField] private HealthComponent m_healthComponent;

    private void OnEnable()
    {
        SetValue();
        m_healthComponent.ValueChanged += SetValue;
    }

    private void OnDisable()
    {
        m_healthComponent.ValueChanged -= SetValue;
    }

    private void SetValue() =>
        m_bar.fillAmount = m_healthComponent.value / m_healthComponent.maxValue;
}
