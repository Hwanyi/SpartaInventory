using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField]
    private Image itemIcon;

    public Item item;
    public GameObject equipIcon;
    public int index;

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

    public void Onclicked()
    {
        if (item == null) return;

        if(item.isEquip)
        {
            item.isEquip = false;
            GameManager.Instance.CharacterInfo.UnEquipItem(item);
            equipIcon.SetActive(false);
        }
        else
        {
            item.isEquip = true;
            GameManager.Instance.CharacterInfo.EquipItem(item);
            equipIcon.SetActive(true);
        }

        UIManager.instance.UIStatus.RefreshUI();
    }
}
