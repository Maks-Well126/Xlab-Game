using System;
using UnityEngine;

[Serializable]
public sealed class PoisonDebuff : TimedBuff
{
    [SerializeField][Min(0)] private float m_inteval = 1;
    [SerializeField][Min(0)] public float m_damagePerSeconds = 2f;

    [NonSerialized] private float m_timer;

    private IHealth m_health;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        m_health = container.GetComponent<IHealth>();
    }

    protected override void OnDeinitializing()
    {
        m_timer = 0;
        m_health = null;
        base.OnDeinitializing();
    }


    protected override void OnUpdated(float deltaTime)
    {
        if(m_health is null)
        {
            Deinitialize();
            return;
        }

        if(m_timer < m_inteval)
        {
            m_timer += deltaTime;
        }
        else
        {
            m_timer = 0;
            m_health.TakeDamage(m_damagePerSeconds);
        }
    }
}