using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyData m_enemyData;
    [SerializeField] private HelthComponent m_health;

    private EnemyData m_data;

    private void Awake()
    {
        Initialize(m_enemyData);
    }

    private void OnEnable()
    {
        m_health.ValueChanged += () =>
        {
            Debug.Log($"health Cganged: {m_health.Value}");
        };

        m_health.Died += OnDied;
    }

    

    private void OnDisable()
    {
        m_health.Died -= OnDied;
        
    }


    public void Initialize(EnemyData data)
    {
        m_data = data;
        m_health.Initialize(data.health);
    }

    private void OnDied()
    {
        Debug.Log("Enemy Died");
        Destroy(gameObject);
    }
}
