using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float attack;
    public float Attack
    {
        set { attack = value; }
        get { return attack; }
    }

    private float defense;
    public float Defense
    {
        set { defense = value; }
        get { return defense; }
    }

    private float maxHealth;
    public float MaxHealth
    {
        set { maxHealth = value; }
        get { return maxHealth; }
    }

    private float health;
    public float Health
    {
        set
        {
            if (health > maxHealth)
                health = maxHealth;
            else
                health = value;
        }
        get { return health; }
    }

    private float critical;
    public float Critical
    {
        get { return critical; }
        set { critical = value; }
    }

    private float gold;
    public float Gold
    {
        set { gold = value; }
        get { return gold; }
    }

    private int exp;
    public int Exp
    {
        set { exp = value; }
        get { return exp; }
    }
}
