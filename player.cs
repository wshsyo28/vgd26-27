using UnityEngine;

public class player : MonoBehaviour
{

    [SerializedField] private int level;
    [SerializedField] private int basehp;
    [SerializedField] private int strength;
    [SerializedField] private int intel;
    [SerializedField] private int hunger;

    private int hp;

    private ScripObj vardata;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        level = vardata.PlayerLevel;
        basehp = vardata.PlayerBaseHealth;
        strength = vardata.PlayerStrength;
        intel = vardata.PlayerIntelligence;
        hunger = vardata.PlayerHunger;

        hp = basehp;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
