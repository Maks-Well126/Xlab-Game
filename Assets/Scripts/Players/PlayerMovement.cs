using System;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private TargetMarker m_targerMarker;
    [SerializeField] private NavMeshAgent m_agent;

    private float m_speed;


    public void OnValidate()
    {
        if(!m_agent)
        {
            m_agent = GetComponent<NavMeshAgent>();
        }
    }

    private void Awake()
    {
        Initialize(m_speed);
    }

    public void Initialize(float speed)
    {
        m_speed = speed;
        m_agent.speed = speed;
    }

    public void SetDestination(Vector3 navMeshpoint)
    {
        m_targerMarker.Show(navMeshpoint);
        m_agent.SetDestination(navMeshpoint);
    }

}
