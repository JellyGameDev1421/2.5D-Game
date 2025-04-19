using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleVisuals : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private TextMeshPro levelText;

    private int currHealth;
    private int maxHealth;
    private int Level;

    private const string LEVEL_ABB = "Lv1: ";

    public void SetStartingValues(int currHealth, int maxHealth, int Level)
    {
        this.currHealth = currHealth;
        this.maxHealth = maxHealth;
        this.Level = Level;

        levelText.text = LEVEL_ABB + this.Level.ToString();

        UpgradeHealthBar();
    }

    public void ChangeHealth()
    {
        this.currHealth = currHealth;
        // If health is 0 than play death animation and destroy battle visual


    }

    public void UpgradeHealthBar()
    {
        healthBar.maxValue = maxHealth;
        healthBar.value = currHealth;
    }
}
