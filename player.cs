using UnityEngine;

public class player : MonoBehaviour
{

    [SerializedField] private int level;
    [SerializedField] private int basehp;
    [SerializedField] private int strength;
    [SerializedField] private int intel;
    [SerializedField] private int hunger;

    [SerializedField] private int speed;

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

        speed = vardata.PlayerMaxSpeed;

        hp = basehp;
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        
    }
}
