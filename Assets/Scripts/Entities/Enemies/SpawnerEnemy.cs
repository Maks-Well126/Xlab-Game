using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private Enemy[] m_enemies;
    [SerializeField] private EnemyData[] m_data;
    [SerializeField] private Transform[] m_spawnPoints;
    [SerializeField] private Transform m_playerTransform;

    private List<Enemy> m_currentEnemies = new();

    public void Spawn()
    {
        foreach (var spawnPoint in m_spawnPoints)
        {
            var enemy = GetEnemy();
            var enemyData = GetEnemyData();

            var enemyInstance = Instantiate(enemy, spawnPoint);
            enemyInstance.Initialize(enemyData, m_playerTransform);

            enemyInstance.Died += OnDied;
        }
    }



    private void OnDied(Enemy enemy)
    {

        DestroyEnemy(enemy);

    }
        
        
    

    private Enemy GetEnemy() =>
        m_enemies[Random.Range(0, m_enemies.Length)];

    private EnemyData GetEnemyData() =>
        m_data[Random.Range(0, m_data.Length)];

    private void DestroyEnemy(Enemy enemy)
    {
        m_currentEnemies.Remove(enemy);

        enemy.Died -= OnDied;
        Destroy(enemy.gameObject);

    }
}
