using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField]
    UIBase uiMain;
    [SerializeField]
    UIBase uiStatus;
    [SerializeField]
    UIBase uiInventory;

    public UIBase UIMain { get { return uiMain; } }
    public UIBase UIStatus { get { return uiStatus; } }
    public UIBase UIInventory { get { return uiInventory; } }

    enum UISTATE
    {
        MAIN,
        STATUS,
        INVENTORY
    };

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

}
