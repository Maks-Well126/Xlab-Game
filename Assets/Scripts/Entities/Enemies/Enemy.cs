using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public event Action<Enemy> Died;

    [SerializeField] private EnemyData m_enemyData;
    [SerializeField] private HelthComponent m_health;

    private EnemyData m_data;

    public HelthComponent health => m_health;
    

    private void OnEnable()
    {
        m_health.Died += OnDied;
    }



    private void OnDisable()
    {
        m_health.Died -= OnDied;

    }
    private void Update()
    {
        if (m_stateMashine.currentState is EnemyState.Dead || !m_data)
        {
            return;
        }
        UpdateState();
    }


    public void Initialize(EnemyData data)
    {
        m_data = data;
        m_health.Initialize(data.health);
        m_attack.Initialize(data.spell, data.attackTime, playerTransform);

        m_stateMashine ?? = new EnemyStateMachine();
    }

    private void UpdateState()
    {
        var isInAttckRange = IsInRange();
        switch(m_stateMachine.currentState)
        {
            case EnemyState.Idle: HendleIdleState(isInAttckRange); break;
           // case EnemyState.Move: HendleIdleState(isInAttckRange); break;
            case EnemyState.Attack: HendleIdleState(isInAttckRange); break;

        }
    }

    private void HendleIdleState(object isInAttckRange)
    {
        throw new NotImplementedException();
    }

    private void OnDied() =>
        Died?.Invoke(this);

}

