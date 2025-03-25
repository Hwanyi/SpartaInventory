using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class Item : ScriptableObject
{
    public Sprite image;

    public string itemName;
    public string itemDescription;

    public float attack;
    public float defense;
    public float maxHp;
    public float critical;

    public bool isEquip = false;

}
