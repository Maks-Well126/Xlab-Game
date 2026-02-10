using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemydata", menuName = "Xlab/Enemies/Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private AttackEnemyType m_enemyType;

    [Header("Parameters")]
    [SerializeField][Min(0)] private float m_health;
    [SerializeField][Range(0f, 100f)] private float m_speed;

    [Header("Attack")]
    [SerializeField] private SpellEnemyData[] m_spells;
    [SerializeField][Min(0)] private float m_attackTime;
    [SerializeField][Min(0)] private float m_attackRange;

    public float health => m_health;

    public float speed => m_speed;

    public IReadOnlyList<SpellEnemyData> spells => m_spells;

    public float attackTime => m_attackTime;

    public float attackRange => m_attackRange;

    public AttackEnemyType enemyType => m_enemyType;
}

[Serializable]
public struct SpellEnemyData
{
    [SerializeField] public int count;
    [SerializeField] public BaseSpellData spell;
}

