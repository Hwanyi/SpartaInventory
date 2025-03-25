using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField]
    private Image itemIcon;

    public Item item;

    public void SetItem()
    {
        if (item != null)
        {
            itemIcon.sprite = item.image;
            itemIcon.enabled = true;
        } 
        else
        {
            itemIcon.enabled = false;
        }
    }

    public void RefreshUI()
    {
        itemIcon.enabled = false;
    }
}
