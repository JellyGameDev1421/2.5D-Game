using UnityEngine;

[CreateAssetMenu(menuName = "New Enemy")]
public class EnemyInfo : ScriptableObject
{
    [Header("Basic Attributes")]
    public string EnemyName;          // Name of the enemy
    public int BaseInitiative;        // Initiative stat used in battle
    public int BaseHealth;            // Enemy's health
    public int BaseStr;               // Enemy's strength

    [Header("Visual Representation")]
    public GameObject EnemyVisualPrefab; // Prefab used in the battle scene
}