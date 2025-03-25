using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : UIBase
{
    public GameObject inventory;

    public GameObject uiSlot;

    private UISlot inventorySlots;

    public Transform inventoryRoot;

    public float slotGap = 45f;

    private int slotCount = 0;
    private int maxSlotCount = 120;

    private void Start()
    {
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        GameObject temp;
        inventoryRoot.GetComponent<RectTransform>().sizeDelta = new Vector2(inventoryRoot.GetComponent<RectTransform>().sizeDelta.x, slotGap * maxSlotCount / 4 + 30f);
        for (int i = 0; i < maxSlotCount / 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                temp = Instantiate(uiSlot, inventoryRoot);
                temp.transform.localPosition = new Vector3(10f + slotGap * j, -20f - slotGap * i);
            }
        }
    }
}
