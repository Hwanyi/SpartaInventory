using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private string playerName;
    public string PlayerName
    {
        get { return playerName; }
    }

    [SerializeField]
    private string playerDescription;
    public string PlayerDescription
    {
        get { return playerDescription; }
    }

    [SerializeField]
    private float attack;
    public float Attack
    {
        private set { attack = value; }
        get { return attack; }
    }

    [SerializeField]
    private float defense;
    public float Defense
    {
        private set { defense = value; }
        get { return defense; }
    }

    [SerializeField]
    private float maxHealth;
    public float MaxHealth
    {
        private set { maxHealth = value; }
        get { return maxHealth; }
    }

    [SerializeField]
    private float health;
    public float Health
    {
        private set
        {
            if (health > maxHealth)
                health = maxHealth;
            else
                health = value;
        }
        get { return health; }
    }

    [SerializeField]
    private float critical;
    public float Critical
    {
        private set { critical = value; }
        get { return critical; }
    }

    [SerializeField]
    private float gold;
    public float Gold
    {
        private set { gold = value; }
        get { return gold; }
    }

    [SerializeField]
    private int exp;
    public int Exp
    {
        private set { exp = value; }
        get { return exp; }
    }

    [SerializeField]
    private int level;
    public int Level
    {
        private set { level = value; }
        get { return level; }
    }

    const int MAXLV = 10;

    public readonly int[] maxExp = new int[MAXLV] { 0, 15, 30, 45, 60, 75, 90, 100, 110, 120};
}
