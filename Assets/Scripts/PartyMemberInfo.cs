using UnityEngine;

[CreateAssetMenu(menuName = "New Party Member")]
public class PartyMemberInfo : ScriptableObject
{
    [Header("Basic Attributes")]
    public string MemberName;          // Name of the party member
    public int StartingLevel;          // Starting level of the character
    public int BaseHealth;             // Base health value
    public int BaseStr;                // Base strength value
    public int BaseInitiative;         // Initiative stat used in battle

    [Header("Visual Representation")]
    public GameObject MemberBattleVisualPrefab;    // Prefab shown in battle
    public GameObject MemberOverworldVisualPrefab; // Prefab shown in the overworld
}