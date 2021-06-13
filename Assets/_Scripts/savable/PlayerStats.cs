using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats 
{
    int intelligence;
    int charisma;
    int social;
    int strength;
    string name;

    public PlayerStats(string name)
    {
        this.name = name;
    }

    public PlayerStats(int intelligence, int charisma, int social, int strength, string name)
    {
        this.intelligence = intelligence;
        this.charisma = charisma;
        this.social = social;
        this.strength = strength;
        this.name = name;
    }

    

    public int Intelligence { get => intelligence; set => intelligence = value; }
    public int Charisma { get => charisma; set => charisma = value; }
    public int Social { get => social; set => social = value; }
    public int Strength { get => strength; set => strength = value; }
    public string Name { get => name; set => name = value; }
}
