using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent (typeof(NavMeshAgent))]
public class EnemyMovement : MonoBehaviour, IAcceleration
{
    [SerializeField] private NavMeshAgent m_agent;

    private Transform m_target;
    private bool m_isMoving;
    private bool m_isinitializied;
    private float m_speed;
    private float m_acceleration;


    private void OnValidate()
    {
        if (!m_agent)
        {
            m_agent = GetComponent<NavMeshAgent>();
        }
            
    }

    public void Initialized(float speed, Transform target)
    {
        m_speed = speed;
        m_target = target;
        m_agent.speed = speed;
        m_isinitializied = true;
        SetSpeed();
    }



    private void Update()
    {
        if(m_isinitializied || !m_isMoving || !m_target)
        {
            return;
        }

        m_agent.SetDestination(m_target.position);
    }

    public void StartMoving()
    {
        if(!m_isinitializied)
        {
            return;
        }

        m_isMoving = true;
        m_agent.isStopped = false;
    }

    public void StopMoving()
    {
        if(m_isinitializied)
        {
            return;
        }

        m_isMoving = false;
        m_agent.isStopped = true;
        m_agent.velocity = Vector3.zero;
    }

    public void IncreaseAcceleration(float delta)
    {
        if (delta < 0)
            throw new ArgumentException("Delta", nameof(delta));
        m_acceleration += delta;
    }

    public void DecreaseAcceleration(float delta)
    {
        if (delta < 0)
            throw new ArgumentException("Delta", nameof(delta));
        m_acceleration -= delta;
    }
    private void SetSpeed()
    {
        var acceleration = m_acceleration > 0
            ? m_acceleration
            : 1;

        m_agent.speed = m_speed * m_acceleration;
    }


}
