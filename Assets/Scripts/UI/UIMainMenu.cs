using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : UIBase
{
    UIManager manager;

    public Button returnBtn;
    public Button statusBtn;
    public Button inventoryBtn;

    public TextMeshProUGUI playerNameTxt;
    public TextMeshProUGUI playerLevelTxt;
    public TextMeshProUGUI playerDescriptionTxt;
    public TextMeshProUGUI playerExpTxt;

    public TextMeshProUGUI goldTxt;

    private void Start()
    {
        manager = UIManager.instance;
    }

    public void OpenMainMenu()
    {

    }

    public void OpenStatus()
    {

    } 
    
    public void OpenInventory()
    {

    }
}
