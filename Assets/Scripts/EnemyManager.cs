using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] private EnemyInfo[] allEnemies;
    [SerializeField] private List<Enemy> currentyEnemies;

    private const float LEVEL_MODIFER = 0.5f;

    private void Awake()
    {
        GenerateEnemyByName("Slime", 10);
    }

    private void GenerateEnemyByName(string enemyName, int level)
    {
        for (int i = 0; i < allEnemies.Length; i++)
        {
            if (allEnemies[i].EnemyName == enemyName)
            {
                Enemy newEnemy = new Enemy();

                newEnemy.EnemyName = allEnemies[i].EnemyName;
                newEnemy.Level = level;
                float levelModifier = (LEVEL_MODIFER * newEnemy.Level);

                newEnemy.MaxHealth = Mathf.RoundToInt(allEnemies[i].BaseHealth + (allEnemies[i].BaseHealth * levelModifier));
                newEnemy.Strength = Mathf.RoundToInt(allEnemies[i].BaseStr + (allEnemies[i].BaseStr * levelModifier));
                newEnemy.CurrentHealth = newEnemy.MaxHealth;
                newEnemy.Initiative = Mathf.RoundToInt(allEnemies[i].BaseInitiative + (allEnemies[i].BaseInitiative * levelModifier));
                newEnemy.EnemyVisualPrefab = allEnemies[i].EnemyVisualPrefab;

                currentyEnemies.Add(newEnemy);
            }
        }
    }
}

[System.Serializable]

public class Enemy
{
    public string EnemyName;
    public int Initiative;
    public int Level;
    public int CurrentHealth;
    public int MaxHealth;
    public int Strength;

    public GameObject EnemyVisualPrefab;
}
