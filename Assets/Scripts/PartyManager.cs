using System.Collections.Generic;
using UnityEngine;

public class PartyManager : MonoBehaviour
{
    // Array to hold all of the party members
    [SerializeField] private PartyMemberInfo[] allMembers;

    // List to hold the current active members
    [SerializeField] private List<PartyMemeber> currentParty;

    //Making default member
    [SerializeField] private PartyMemberInfo defaultPartyMember;

    private void Awake()
    {
        AddMemberToPartyByName(defaultPartyMember.MemberName);
    }

    // Function to add memebers to party by name
    public void AddMemberToPartyByName(string memberName)
    {
        // Loops through the party going off array size
        for (int i = 0; i < allMembers.Length; i++)
        {
            // Check if the current member's name matches the input name
            if (allMembers[i].MemberName == memberName)
            {
                // Creates new party member instance for new member
                PartyMemeber newPartyMember = new PartyMemeber();

                //Assigns attributes to them
                newPartyMember.MemberName = allMembers[i].MemberName;

                newPartyMember.Level = allMembers[i].StartingLevel;

                newPartyMember.CurrentHealth = allMembers[i].BaseHealth;

                newPartyMember.MaxHealth = newPartyMember.CurrentHealth;

                newPartyMember.Strength = allMembers[i].BaseStr;

                newPartyMember.Initiative = allMembers[i].BaseInitiative;

                newPartyMember.MemberBattleVisualPrefab = allMembers[i].MemberBattleVisualPrefab;

                newPartyMember.MemberOverworldVisualPrefab = allMembers[i].MemberOverworldVisualPrefab;

                //Using list because the list may change but party size won't change
                currentParty.Add(newPartyMember);
            }
        }
    }
}

[System.Serializable]

public class PartyMemeber
{
    public string MemberName;
    public int Level;
    public int CurrentHealth;
    public int MaxHealth;
    public int Strength;
    public int Initiative;
    public int CurrentExp;
    public int MaxExp;

    public GameObject MemberBattleVisualPrefab;
    public GameObject MemberOverworldVisualPrefab;
}
