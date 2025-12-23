
using System;
using UnityEngine;

public class HelthComponent : MonoBehaviour, IHealth, IEffectable
{
    public event Action Died;
    public event Action ValueChanged;

    private float m_value;
    private bool m_initiaize;

    public float value
    {
        get => m_value;
        private set
        {
            if(Mathf.Approximately(m_value, value))
            {
                return;
            }

            m_value = value < 0 ? 0 : value;
            ValueChanged?.Invoke();

            if(m_value is 0)
            {
                Died?.Invoke();
            }
 
            
        }
    }

    public void Initialize(float value)
    {
        if(m_initiaize)
        {
            throw new InvalidOperationException("HelthComponent is already initialized");
        }
        
    }
    public void Heal(float heal)
    {
        if(heal < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(heal), heal, "heal cannot be negative");
        }

        value += heal;
    }
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(damage), damage, "heal cannot be negative");
        }

        value -= damage;

    }

     
   
}
